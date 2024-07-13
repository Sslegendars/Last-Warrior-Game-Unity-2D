using System.Collections;
using UnityEngine;
public class PlayerMovement : CharacterMovement 
{    
    [HideInInspector]
    public GroundCheck groundCheck;
    [HideInInspector]
    public bool isDashing = false;

    private PlayerAnimatorController playerAnimatorController;

    private const float jumpForce = 25f;
    private const float dashSpeed = 15f;
    private const float dashDuration = 0.5f;
    private const float dashEndDuration = 1f;

    private void Start()
    {
        InitializeComponents();
    }
    public void Move(float horizontalInput)
    {
        playerAnimatorController.IdleToRunAnimation(Mathf.Abs(horizontalInput));
        if (!isDashing)
        {
            MovingRigidbody(horizontalInput, Speed);
            if (horizontalInput != 0)
            {
                FaceFlipping(new Vector2(horizontalInput, 0));
            }
        }
        else
        {
            MovingRigidbody(horizontalInput, dashSpeed);
        }
    }   

    private void MovingRigidbody(float horizontalInput, float speed)
    {
        Vector2 velocity = new Vector2(horizontalInput * speed, _rigidbody.velocity.y);
        _rigidbody.velocity = velocity;
    }    
    public void Jumping()
    {
        playerAnimatorController.StartJumpingAnimation();
        AudioManager.Instance.Play(AudioManager.playerJumpSoundName);
        _rigidbody.AddForce(Vector2.up * jumpForce, ForceMode2D.Impulse);
        
    }
    public void StopJumping()
    {
        playerAnimatorController.StopJumpingAnimation();
    }    
    
    public void Dash(float direction)
    {
        StartCoroutine(DashCoroutine(direction));
    }

    private IEnumerator DashCoroutine(float direction)
    {
        isDashing = true;
        AudioManager.Instance.Play(AudioManager.playerDashSoundName);
        playerAnimatorController.StartDashAnimation();
        _rigidbody.velocity = new Vector2(direction * dashSpeed, _rigidbody.velocity.y);
        yield return new WaitForSeconds(dashDuration);

        isDashing = false;
        playerAnimatorController.StopDashAnimation();
        yield return new WaitForSeconds(dashEndDuration);
    }

    private void InitializeComponents()
    {
        SetScale(2f, 2f);
        Speed = 5f;
    } 
    public void Intialize(GroundCheck groundCheck, PlayerAnimatorController playerAnimatorController)
    {
        this.groundCheck = groundCheck;
        this.playerAnimatorController = playerAnimatorController;
    }
    
}
