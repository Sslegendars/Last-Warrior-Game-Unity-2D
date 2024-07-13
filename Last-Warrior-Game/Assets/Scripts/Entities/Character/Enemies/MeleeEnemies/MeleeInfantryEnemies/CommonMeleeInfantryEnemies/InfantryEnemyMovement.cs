using UnityEngine;

public class InfantryEnemyMovement : EnemyMovement
{
    [HideInInspector]
    public GroundCheck groundCheck;
    public override void Move(Vector2 lookDirection)
    {
        if (groundCheck.IsOnGround)
        {
            base.Move(lookDirection);
        }
        
    }
    public void Initialize(GroundCheck groundCheck)
    {
        this.groundCheck = groundCheck;
    }
    
}
