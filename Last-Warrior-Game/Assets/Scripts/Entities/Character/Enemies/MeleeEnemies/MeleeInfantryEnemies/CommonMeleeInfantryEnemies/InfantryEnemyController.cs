
public class InfantryEnemyController : MeleeEnemyController
{
    protected InfantryEnemyMovement infantryEnemyMovement;
       
    protected override void HandleEnemyBehavior()
    {
        if (infantryEnemyMovement.groundCheck.IsOnGround)
        {
            base.HandleEnemyBehavior();
        }
        
    }
    public void Initialize(InfantryEnemyMovement infantryEnemyMovement)
    {
        this.infantryEnemyMovement = infantryEnemyMovement;
    }
   
}
