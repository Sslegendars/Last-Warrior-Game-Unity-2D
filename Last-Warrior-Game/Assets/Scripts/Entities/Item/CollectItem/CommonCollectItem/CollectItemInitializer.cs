using UnityEngine;

public class CollectItemInitializer : ItemInitializer
{
    public CollectItemMovement collectItemMovement;
    public Rigidbody2D _rigidbody;
    
    protected CollectItem collectItem;

    private void Awake()
    {
        InitializeComponents();
    }
    protected virtual void InitializeComponents()
    {
        FindPlayerController();
        collectItem = (CollectItem)item;
        collectItemMovement.Initialize(_rigidbody);
        collectItem.Initialize(collectItemMovement, playerController);
        
    }
}
