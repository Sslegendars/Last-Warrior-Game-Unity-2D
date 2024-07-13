
public class MeleeInfantryEnemyInitializer : MeleeEnemyIntializer
{
    public GroundCheck groundCheck;
    protected InfantryEnemyMovement infantryEnemyMovement;
    protected InfantryEnemyController infantryEnemyController;

    protected override void InitializeComponents()
    {
        base.InitializeComponents();
        infantryEnemyMovement = (InfantryEnemyMovement)enemyMovement;
        infantryEnemyController = (InfantryEnemyController)meleeEnemyController;

        infantryEnemyMovement.Initialize(groundCheck);
        infantryEnemyController.Initialize(infantryEnemyMovement);
    }
}
