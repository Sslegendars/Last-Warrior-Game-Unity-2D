using UnityEngine;

public class ItemInitializer : MonoBehaviour
{
    public Item item;
    [HideInInspector]
    public PlayerController playerController;


    protected void FindPlayerController()
    {
        playerController = FindObjectOfType<PlayerController>();
    }
}
