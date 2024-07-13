
public class BossEnemyInitializer : MeleeInfantryEnemyInitializer
{
    public BosseEnemySpell bossEnemySpell;
    public BossEnemyPushForceHitBox bossEnemyPushForceHitBox;


    private BossEnemyHitBox bossEnemyHitBox;
    private BossEnemyMovement bossEnemyMovement;
    private BossEnemyController bossEnemyController;
    private BossEnemyHealthSystem bossEnemyHealthSystem;
    private BossEnemyAttackController bossEnemyAttackController;
    private BossEnemyAnimatorController bossEnemyAnimatorController;    
    
    protected override sealed void InitializeComponents()
    {
        base.InitializeComponents();
        bossEnemyHitBox = (BossEnemyHitBox)hazardHitBox;
        bossEnemyMovement = (BossEnemyMovement)infantryEnemyMovement;
        bossEnemyController = (BossEnemyController)infantryEnemyController;
        bossEnemyHealthSystem = (BossEnemyHealthSystem)enemyHealthSystem;        
        bossEnemyAttackController = (BossEnemyAttackController)meleeEnemyAttackController;
        bossEnemyAnimatorController = (BossEnemyAnimatorController)enemyAnimatorController;

        bossEnemySpell.Initialize(bossEnemyHealthSystem, playerController);
        bossEnemyPushForceHitBox.Intialize(playerController);
        bossEnemyController.Initialize(bossEnemyAttackController, bossEnemyMovement);
        bossEnemyAttackController.Initialize(bossEnemyAnimatorController);
        
       
        

    }
}
