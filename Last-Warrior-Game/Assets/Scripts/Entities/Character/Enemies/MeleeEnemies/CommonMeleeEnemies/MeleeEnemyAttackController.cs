using System.Collections;
public class MeleeEnemyAttackController : EnemyAttackController
{   

    protected virtual void Start()
    {
        HandleAttackRange();
    }
    protected override void IsAttacking()
    {
        base.IsAttacking();
        StartCoroutine(AttackWithAnimationCoroutine());
    }
    public override void StopAttacking()
    {
        StopCoroutine(AttackWithAnimationCoroutine());
        base.StopAttacking();
        
    }
    protected virtual void HandleAttackRange()
    {
        AttackRange = AttackStartingDistance + 1f;
    }
    private IEnumerator AttackWithAnimationCoroutine()
    {
        CheckAttackRange = true;
        yield return StartCoroutine(enemyAnimatorController.AttackAnimationCoroutine());
        CheckAttackRange = false;
        isAttacking = false;
    }
}
