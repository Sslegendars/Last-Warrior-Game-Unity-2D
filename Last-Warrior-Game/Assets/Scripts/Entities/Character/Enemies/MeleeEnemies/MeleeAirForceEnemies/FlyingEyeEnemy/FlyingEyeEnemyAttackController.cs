public class FlyingEyeEnemyAttackController : MeleeEnemyAttackController
{
        
    protected override void HandleAttackRange()
    {
        AttackStartingDistance = 0.5f;
        base.HandleAttackRange();
    }
}
 