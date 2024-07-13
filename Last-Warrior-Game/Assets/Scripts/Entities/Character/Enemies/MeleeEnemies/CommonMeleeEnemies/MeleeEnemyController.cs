
public class MeleeEnemyController : EnemyController
{
    protected MeleeEnemyAttackController meleeEnemyAttackController;
       
    protected override void HandleStunnedState()
    {
        meleeEnemyAttackController.StopAttacking();
        base.HandleStunnedState();
    }
    public void Initialize(MeleeEnemyAttackController meleeEnemyAttackController)
    {
        this.meleeEnemyAttackController = meleeEnemyAttackController;
    }
}
