
public class GoblinEnemyAnimatorController : EnemyAnimatorController
{
    private void Start()
    {
        InitializeComponents();
    }
    private void InitializeComponents()
    {
        SetAnimationDuration(0.65f, 0.75f);
    }
}
