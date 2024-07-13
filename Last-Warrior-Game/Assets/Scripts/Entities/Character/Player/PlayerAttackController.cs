using System.Collections;
public class PlayerAttackController : CharacterAttackController
{
    protected PlayerAnimatorController playerAnimatorController;
   
    public void Initialize(PlayerAnimatorController playerAnimatorController)
    {
        this.playerAnimatorController = playerAnimatorController;
    }
    protected override void IsAttacking()
    {
        base.IsAttacking();
        StartCoroutine(AttackWithAnimationCoroutine());
    }
    private IEnumerator AttackWithAnimationCoroutine()
    {
        AudioManager.Instance.Play(AudioManager.playerAttackSoundName);
        yield return StartCoroutine(playerAnimatorController.AttackAnimationCoroutine());
        isAttacking = false;        
    }
}
