using System.Collections;
using UnityEngine;

public class BosseEnemySpell : MonoBehaviour
{
    [SerializeField] 
    private GameObject gravePrefab;
    [SerializeField] 
    private int damageAmount = 10;
    private BossEnemyHealthSystem bossEnemyHealthSystem;
    private PlayerController playerController;
        
    private void OnEnable()
    {
        if (playerController != null)
        {
            SpellObjectPosition();
        }
        StartCoroutine(SpawnGraveCoroutine());
    }

    
    private void SpellObjectPosition()
    {
        if (playerController != null)
        {
            transform.position = playerController.transform.position + Vector3.up * 0.5f;
        }
    }   

    private IEnumerator SpawnGraveCoroutine()
    {
        yield return new WaitForSeconds(1f);
        Instantiate(gravePrefab, transform.position, Quaternion.identity);
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            if (playerController != null && bossEnemyHealthSystem != null)
            {
                playerController.playerHealthSystem.TakeDamage(damageAmount);
                bossEnemyHealthSystem.StealHealth(damageAmount);
            }
        }
    }
    public void Initialize(BossEnemyHealthSystem bossEnemyHealthSystem, PlayerController playerController)
    {
        this.bossEnemyHealthSystem = bossEnemyHealthSystem;
        this.playerController = playerController;
    }
}
