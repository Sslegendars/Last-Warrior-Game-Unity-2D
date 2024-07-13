using UnityEngine;
using UnityEngine.UI;

public class WaveCounter : MonoBehaviour
{
    [SerializeField] 
    private Text waveText;  
     
    void Update()
    {
        UpdateWaveText();
    }
    void UpdateWaveText()
    {
        waveText.text = "Wave " + SpawnManager.Instance.currentWave.ToString();
    }
}
