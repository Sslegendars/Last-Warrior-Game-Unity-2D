using UnityEngine;

public class CharacterMovement : Movement
{   
    protected float scaleX;
    protected float scaleY;

    
    protected void SetScale(float ScaleX, float ScaleY)
    {
        scaleX = ScaleX;
        scaleY = ScaleY;
    }

    protected void FaceFlipping(Vector2 lookDirection)
    {
        if (lookDirection.x > 0)
        {
            SetFaceScale(scaleX, scaleY);
        }
        else if (lookDirection.x < 0)
        {
            SetFaceScale(-scaleX, scaleY);
        }
    }
    protected virtual void SetFaceScale(float scaleX, float scaleY)
    {
        transform.localScale = new Vector2(scaleX, scaleY);
    }
   
    
    
    
   
    
}
