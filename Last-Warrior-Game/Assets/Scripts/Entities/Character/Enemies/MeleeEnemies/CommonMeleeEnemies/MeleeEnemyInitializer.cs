
public class MeleeEnemyIntializer : EnemyInitializer
{
    protected MeleeEnemyAttackController meleeEnemyAttackController;
    protected MeleeEnemyController meleeEnemyController;

    protected override void InitializeComponents()
    {
        base.InitializeComponents();
        meleeEnemyController = (MeleeEnemyController)enemyController;
        meleeEnemyAttackController = (MeleeEnemyAttackController)enemyAttackController;

        meleeEnemyController.Initialize(meleeEnemyAttackController);

    }
}
