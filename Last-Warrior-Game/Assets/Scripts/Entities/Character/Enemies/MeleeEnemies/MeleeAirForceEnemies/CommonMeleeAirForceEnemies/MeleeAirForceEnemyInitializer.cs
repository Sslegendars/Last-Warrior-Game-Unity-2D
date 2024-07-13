public class MeleeAirForceEnemyInitializer : MeleeEnemyIntializer
{
    protected AirForceEnemyMovement airForceEnemyMovement;
    protected AirForceEnemyController airForceEnemyController;

    protected override void InitializeComponents()
    {
        base.InitializeComponents();        
        airForceEnemyMovement = (AirForceEnemyMovement)enemyMovement;
        airForceEnemyController = (AirForceEnemyController)enemyController;

        airForceEnemyController.Initialize(airForceEnemyMovement);
    }
}
