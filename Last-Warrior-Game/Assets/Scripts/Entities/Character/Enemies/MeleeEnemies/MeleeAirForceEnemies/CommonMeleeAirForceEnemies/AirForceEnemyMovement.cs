
public class AirForceEnemyMovement : EnemyMovement
{
    private void Start()
    {
        InitializeComponents();
    }
    protected virtual void InitializeComponents()
    {        
        GravityScale(0);
    }
    protected void GravityScale(float gravityScale)
    {
        _rigidbody.gravityScale = gravityScale;
    }
    public void AirForceEnemyGravityScaleWhenDead()
    {
        GravityScale(1f);
    }

}
