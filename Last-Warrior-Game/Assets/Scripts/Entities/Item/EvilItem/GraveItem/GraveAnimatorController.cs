public class GraveAnimatorController : AnimatorController
{
    private const string hitTriggerName = "Hit_Trigger";

    public void TakeHitAnimation()
    {
        SetAnimationTrigger(hitTriggerName);
    }
}
