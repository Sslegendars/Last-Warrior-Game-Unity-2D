
public class GoblinEnemyAttackController : MeleeEnemyAttackController
{     
    protected override void HandleAttackRange()
    {
        AttackStartingDistance = 0.8f;
        base.HandleAttackRange();
    }
}
