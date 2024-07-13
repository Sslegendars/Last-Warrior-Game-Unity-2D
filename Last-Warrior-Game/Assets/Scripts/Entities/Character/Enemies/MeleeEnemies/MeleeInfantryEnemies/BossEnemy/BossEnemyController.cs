public class BossEnemyController : InfantryEnemyController
{
    private BossEnemyAttackController bossEnemyAttackController;
    private BossEnemyMovement bossEnemyMovement;     
      
    protected override void HandleEnemyBehavior()
    {
        if (bossEnemyMovement.groundCheck.IsOnGround)
        {
            if (distanceToPlayer <= bossEnemyMovement.MoveToPlayerDistance && bossEnemyAttackController.CanCastSpell)
            {
                base.HandleEnemyBehavior();
            }
            else
            {
                MagicAttackBehavior();
            }

        }
            
    }
    
    
    private void MagicAttackBehavior()
    {
        bossEnemyMovement.StopMoving();
        bossEnemyAttackController.MagicAttack();
    }   
    protected override void HandleStunnedState()
    {
        bossEnemyAttackController.StopMagicAttack();
        base.HandleStunnedState();       

    }
    protected override void DisableComponents()
    {
        bossEnemyAttackController.StopMagicAttack();
        base.DisableComponents();
       
    } 
    public void Initialize(BossEnemyAttackController bossEnemyAttackController, BossEnemyMovement bossEnemyMovement)
    {
        this.bossEnemyAttackController = bossEnemyAttackController;
        this.bossEnemyMovement = bossEnemyMovement;
    }

}
