
public class AirForceEnemyController : MeleeEnemyController
{
    private bool disableCollider = false;
    protected AirForceEnemyMovement airForceEnemyMovement;
    
    protected override void DisableComponents()
    {             
        airForceEnemyMovement.AirForceEnemyGravityScaleWhenDead();
        if (disableCollider)
        {
            base.DisableComponents();
        }
    }
    private void OnCollisionEnter2D(UnityEngine.Collision2D other)
    {
        if (other.collider.CompareTag("Ground"))
        {
            disableCollider = true;
        }
    }
    public void Initialize(AirForceEnemyMovement airForceEnemyMovement)
    {
        this.airForceEnemyMovement = airForceEnemyMovement;
    }
}
