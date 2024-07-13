using UnityEngine;
public class HazardHitBox : HitBox
{
    protected PlayerController playerController;
    protected virtual void Start()
    {
        InitializeComponents();        
    }
    protected override void PushForceApply(Collider2D other, Rigidbody2D otherRigidbody)
    {
        if (playerController != null)
        {
            base.PushForceApply(other, otherRigidbody);
            playerController.applyForce = true;
        }
    }
    protected override void TriggerExitBool()
    {
        base.TriggerExitBool();
        playerController.applyForce = false;
    }
    protected virtual void InitializeComponents()
    {
        tagName = "Player";        
    }
    public void Intialize(PlayerController playerController)
    {
        this.playerController = playerController;
    }



}
