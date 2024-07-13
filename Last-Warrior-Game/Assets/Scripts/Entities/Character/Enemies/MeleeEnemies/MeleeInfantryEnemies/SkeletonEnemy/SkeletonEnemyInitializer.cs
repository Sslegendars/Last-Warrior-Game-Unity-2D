
public class SkeletonEnemyInitializer : MeleeInfantryEnemyInitializer
{
    private SkeletonEnemyHitBox skeletonEnemyHitBox;
    private SkeletonEnemyMovement skeletonEnemyMovement;
    private SkeletonEnemyController skeletonEnemyController;
    private SkeletonEnemyHealthSystem skeletonEnemyHealthSystem;
    private SkeletonEnemyAttackController skeletonEnemyAttackController;
    private SkeletonEnemyAnimatorController skeletonEnemyAnimatorController; 

    protected sealed override void InitializeComponents()
    {
        base.InitializeComponents();
        skeletonEnemyHitBox = (SkeletonEnemyHitBox)hazardHitBox;
        skeletonEnemyMovement = (SkeletonEnemyMovement)infantryEnemyMovement;
        skeletonEnemyController = (SkeletonEnemyController)infantryEnemyController;
        skeletonEnemyHealthSystem = (SkeletonEnemyHealthSystem)enemyHealthSystem;
        skeletonEnemyAttackController = (SkeletonEnemyAttackController)meleeEnemyAttackController;
        skeletonEnemyAnimatorController = (SkeletonEnemyAnimatorController)enemyAnimatorController;

    }
}
