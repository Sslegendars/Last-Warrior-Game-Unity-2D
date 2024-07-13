
public class BossEnemyMovement : InfantryEnemyMovement
{
    private const float moveToPlayerDistance = 7f;

    private void Start()
    {
        InitializeComponents();
    }
    public float MoveToPlayerDistance
    {
        get{ return moveToPlayerDistance; }
    }
    private void InitializeComponents()
    {        
        SetScale(-2, 2);
        Speed = 7f;
    }


}
