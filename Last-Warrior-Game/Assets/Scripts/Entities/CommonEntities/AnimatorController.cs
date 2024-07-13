using UnityEngine;

public class AnimatorController : MonoBehaviour
{
    protected Animator _animator;
    
    protected void SetAnimationTrigger(string triggerName)
    {
        _animator.SetTrigger(triggerName);
    }    
    
    public void Initialize(Animator _animator)
    {
        this._animator = _animator;
    }
    
}
