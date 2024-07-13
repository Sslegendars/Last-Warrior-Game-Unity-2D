
public class CollectItem : Item
{
    protected CollectItemMovement collectItemMovement;
    protected PlayerController playerController;
    

    protected override void Start()
    {
        base.Start();
        

        if (collectItemMovement._rigidbody != null && gameObject != null)
        {
            collectItemMovement.Drop();
        }
        

    }
    private void FixedUpdate()
    {
        if (gameObject != null)
        {
            collectItemMovement.Rotate();
        }
    }
    public void Initialize(CollectItemMovement collectItemMovement, PlayerController playerController)
    {
        this.collectItemMovement = collectItemMovement;
        this.playerController = playerController;
    }
   
}