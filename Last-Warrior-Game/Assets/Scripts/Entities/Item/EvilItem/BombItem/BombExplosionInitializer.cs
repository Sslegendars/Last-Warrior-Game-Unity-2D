using UnityEngine;
public class BombExplosionInitializer : MonoBehaviour
{
    public BombExplosionHitBox bombExplosionHitBox;
    [HideInInspector]
    public PlayerController playerController;

    private void Awake()
    {
        BombTargetInitialize();
        bombExplosionHitBox.Intialize(playerController);        
    }
    private void BombTargetInitialize()
    {
        playerController = FindObjectOfType<PlayerController>();
    }
}
