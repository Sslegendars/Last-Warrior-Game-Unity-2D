
public class SkeletonEnemyMovement : InfantryEnemyMovement
{
    private void Start()
    {
        InitializeComponents();
    }
    private void InitializeComponents()
    {
        SetScale(1.5f,1.5f);
        Speed = 5f;
    }

}
