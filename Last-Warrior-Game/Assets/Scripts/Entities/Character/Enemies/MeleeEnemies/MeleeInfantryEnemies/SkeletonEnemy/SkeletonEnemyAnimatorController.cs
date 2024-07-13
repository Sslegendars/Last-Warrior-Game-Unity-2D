
public class SkeletonEnemyAnimatorController : EnemyAnimatorController
{
    private void Start()
    {
        InitializeComponents();
    }
    private void InitializeComponents()
    {
        SetAnimationDuration(0.5f, 1.5f);
    }
}
