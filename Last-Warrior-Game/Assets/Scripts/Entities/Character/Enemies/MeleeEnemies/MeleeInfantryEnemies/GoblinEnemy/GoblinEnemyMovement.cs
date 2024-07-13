
public class GoblinEnemyMovement : InfantryEnemyMovement
{
    private void Start()
    {
        InitializeComponents();
    }
    private void InitializeComponents()
    {
        SetScale(2f, 2f);
        Speed = 8f;
    }
    
}
