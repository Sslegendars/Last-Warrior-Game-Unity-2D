
public class MushroomEnemyAttackController : MeleeEnemyAttackController
{  
    protected override void HandleAttackRange()
    {
        AttackStartingDistance = 0.45f;
        base.HandleAttackRange();
    }
}
