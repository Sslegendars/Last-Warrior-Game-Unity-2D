public class FlyingEyeEnemyInitializer : MeleeAirForceEnemyInitializer
{
    private FlyingEyeEnemyMovement flyingEyeEnemyMovement;
    private FlyingEyeEnemyController flyingEyeEnemyController;
    private FlyingEyeEnemyHealthSystem flyingEyeEnemyHealthSystem;
    private FlyingEyeAnimatorController flyingEyeAnimatorController;
    private FlyingEyeEnemyAttackController flyingEyeEnemyAttackController;

    protected override sealed void InitializeComponents()
    {
        base.InitializeComponents();
        flyingEyeEnemyMovement = (FlyingEyeEnemyMovement)airForceEnemyMovement;
        flyingEyeEnemyController = (FlyingEyeEnemyController)airForceEnemyController;
        flyingEyeEnemyHealthSystem = (FlyingEyeEnemyHealthSystem)enemyHealthSystem;
        flyingEyeAnimatorController = (FlyingEyeAnimatorController)enemyAnimatorController;
        flyingEyeEnemyAttackController = (FlyingEyeEnemyAttackController)meleeEnemyAttackController;    
    }

}
