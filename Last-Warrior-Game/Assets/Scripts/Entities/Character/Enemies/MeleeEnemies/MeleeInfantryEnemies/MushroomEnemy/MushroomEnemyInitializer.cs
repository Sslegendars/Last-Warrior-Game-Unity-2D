public class MushroomEnemyInitializer : MeleeInfantryEnemyInitializer
{
    private MushroomEnemyHitBox mushroomEnemyHitBox;
    private MushroomEnemyMovement mushroomEnemyMovement;
    private MushroomEnemyController mushroomEnemyController;
    private MushroomEnemyHealthSystem mushroomEnemyHealthSystem;
    private MushroomEnemyAttackController mushroomEnemyAttackController;
    private MushroomEnemyAnimatorController mushroomEnemyAnimatorController;

    protected sealed override void InitializeComponents()
    {
        base.InitializeComponents();
        mushroomEnemyHitBox = (MushroomEnemyHitBox)hazardHitBox;
        mushroomEnemyMovement = (MushroomEnemyMovement)infantryEnemyMovement;
        mushroomEnemyController = (MushroomEnemyController)infantryEnemyController;
        mushroomEnemyHealthSystem = (MushroomEnemyHealthSystem)enemyHealthSystem;
        mushroomEnemyAttackController = (MushroomEnemyAttackController)meleeEnemyAttackController;
        mushroomEnemyAnimatorController = (MushroomEnemyAnimatorController)enemyAnimatorController;
    }
}
