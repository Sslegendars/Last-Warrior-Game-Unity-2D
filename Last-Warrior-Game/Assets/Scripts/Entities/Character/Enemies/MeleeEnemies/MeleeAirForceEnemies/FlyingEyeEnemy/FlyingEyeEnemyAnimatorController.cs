
public class FlyingEyeAnimatorController : EnemyAnimatorController
{
    private void Start()
    {
        InitializeComponents();
    }
    private void InitializeComponents()
    {
        SetAnimationDuration(0.75f, 1.2f);
    }
}
