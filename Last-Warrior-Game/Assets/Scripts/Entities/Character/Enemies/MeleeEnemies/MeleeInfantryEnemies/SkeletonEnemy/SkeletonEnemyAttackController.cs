

public class SkeletonEnemyAttackController : MeleeEnemyAttackController
{  
    protected override void HandleAttackRange()
    {
        AttackStartingDistance = 1f;
        base.HandleAttackRange();

    }
}
