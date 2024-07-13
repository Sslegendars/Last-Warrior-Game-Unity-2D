using System.Collections;
using UnityEngine;

public class SpawnManager : MonoSingleton<SpawnManager>
{   [Header("Spawning Enemy Object")]  
    [SerializeField] 
    private GameObject[] enemyPrefabs; 
    [Header("BossEnemy And GraveItem Spawning")]
    [SerializeField] 
    private GameObject bossEnemyPrefab;
    [SerializeField]
    private GameObject graveItemPrefabs;
    [SerializeField] 
    private GameObject[] cloudPrefabs;
    [Header("Spawn location")]
    [SerializeField] 
    private Transform[] enemySpawnPoints;
    [SerializeField] 
    private GameObject[] cloudsSpawnPoint;

    public int currentWave = 0;

    private const float initialSpawnDelay = 2f; 
    private const float waveInterval = 5f;
    private const float spawnInterval = 5f;
    private const float cloudsSpawndelay = 7.5f;

    private const int initialEnemiesPerWave = 5;     
    private const int enemiesIncreasePerWave = 1;    
    private const int maxWaveNumber = 10;
   
    private int enemiesPerWave;
    private bool bossSpawned = false;

    void Start()
    {
        StartCoroutine(SpawnWaves());
        StartCoroutine(SpawnClouds());
        bossEnemyPrefab.SetActive(false);
        graveItemPrefabs.SetActive(false);
    }
    private IEnumerator SpawnWaves()
    {
        yield return new WaitForSeconds(initialSpawnDelay);

        while (currentWave < maxWaveNumber)
        {
            currentWave++;

            enemiesPerWave = initialEnemiesPerWave + (currentWave - 1) * enemiesIncreasePerWave;

            for (int i = 0; i < enemiesPerWave; i++)
            {
                GameObject enemyPrefab = enemyPrefabs[Random.Range(0, enemyPrefabs.Length)];
                Transform spawnPoint = enemySpawnPoints[Random.Range(0, enemySpawnPoints.Length)];

                Instantiate(enemyPrefab, spawnPoint.position, spawnPoint.rotation);
                yield return new WaitForSeconds(spawnInterval);
            }

            yield return new WaitUntil(() => GetActiveEnemiesCount() == 0);

            yield return new WaitForSeconds(waveInterval);
        }

        if (!bossSpawned)
        {
            bossSpawned = true;
            bossEnemyPrefab.SetActive(true);
            graveItemPrefabs.SetActive(true);
        }
    }

    private IEnumerator SpawnClouds()
    {
        while (true)
        {
            yield return new WaitForSeconds(cloudsSpawndelay);

            GameObject cloudPrefab = cloudPrefabs[Random.Range(0, cloudPrefabs.Length)];
            GameObject cloudSpawnPoints = cloudsSpawnPoint[Random.Range(0, cloudsSpawnPoint.Length)];
            Instantiate(cloudPrefab, cloudSpawnPoints.transform.position, cloudSpawnPoints.transform.rotation);
        }
    }

    private int GetActiveEnemiesCount()
    {
        GameObject[] activeEnemies = GameObject.FindGameObjectsWithTag("Enemy");
        return activeEnemies.Length;
    }
}
