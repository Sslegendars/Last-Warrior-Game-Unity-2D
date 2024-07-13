using System.Collections;
using UnityEngine;

public class PlayerAnimatorController : CharacterAnimatorController
{
    private const string speedFloatName = "Speed";
    private const string jumpingBoolName = "IsJumping";
    private const string attackTriggerName = "Attack_Trigger";
    private const string dashBoolName = "Dash_Bool";
    

    private const float attackAnimationDelay = 0.8f;
    public void IdleToRunAnimation(float horizontalInput)
    {
        _animator.SetFloat(speedFloatName, horizontalInput);
    }
   
    public void StartJumpingAnimation()
    {       
        StartAnimation(jumpingBoolName);
    } 
    public void StopJumpingAnimation()
    {
        StartCoroutine(StopJumpingAnimationCoroutine());
    }
    private IEnumerator StopJumpingAnimationCoroutine()
    {
        yield return new WaitForSeconds(1f);
        StopAnimation(jumpingBoolName);
    }
    
    public void StartDashAnimation()
    {
        StartAnimation(dashBoolName);
    }
    public void StopDashAnimation()
    {
        StopAnimation(dashBoolName);
    }
    public void AttackAnimationTrigger()
    {
        SetAnimationTrigger(attackTriggerName);
    }
    public IEnumerator AttackAnimationCoroutine()
    {        
        AttackAnimationTrigger();        
        yield return new WaitForSeconds(attackAnimationDelay);
    }

}
