
public class GoblinEnemyInitializer : MeleeInfantryEnemyInitializer
{
    private GoblinEnemyHitBox goblinEnemyHitBox;
    private GoblinEnemyMovement goblinEnemyMovement;
    private GoblinEnemyController goblinEnemyController;
    private GoblinEnemyHealthSystem goblinEnemyHealthSystem;
    private GoblinEnemyAttackController goblinEnemyAttackController;
    private GoblinEnemyAnimatorController goblinEnemyAnimatorController; 
    protected override sealed void InitializeComponents()
    {
        base.InitializeComponents();
        goblinEnemyHitBox = (GoblinEnemyHitBox)hazardHitBox;
        goblinEnemyMovement = (GoblinEnemyMovement)infantryEnemyMovement;
        goblinEnemyController = (GoblinEnemyController)infantryEnemyController;
        goblinEnemyHealthSystem = (GoblinEnemyHealthSystem)enemyHealthSystem;
        goblinEnemyAttackController = (GoblinEnemyAttackController)meleeEnemyAttackController;
        goblinEnemyAnimatorController = (GoblinEnemyAnimatorController)enemyAnimatorController; 
    }
}
