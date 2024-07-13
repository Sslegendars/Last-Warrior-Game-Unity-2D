
public class FlyingEyeEnemyMovement : AirForceEnemyMovement
{      
    protected override void InitializeComponents()
    {        
        base.InitializeComponents();
        SetScale(2f, 2f);
        Speed = 2f;
    }
    
}
