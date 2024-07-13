using System.Collections;
using UnityEngine;

public class BossEnemyAttackController : MeleeEnemyAttackController
{
    private BossEnemyAnimatorController bossEnemyAnimatorController;  
    [SerializeField]
    private GameObject _spell;
    private bool canCastSpell = true;    
    public bool CanCastSpell
    {
        get { return canCastSpell; }
    }
    protected override void Start()
    {        
        base.Start();       
        SetSpellActive(false);
    }
    protected override void HandleAttackRange()
    {
        AttackStartingDistance = 1f;
        base.HandleAttackRange();
    }
    public override void Attacking()
    {
        base.IsAttacking();
    }
    public void MagicAttack()
    {
        if (canCastSpell)
        {
            StartCoroutine(MagicAttackCoroutine());
        }
        else
        {
            StopCoroutine(MagicAttackCoroutine());
        }

    }
    public void StopMagicAttack()
    {
        StopCoroutine(MagicAttackCoroutine());
        canCastSpell = true;
    }
    
    private void SetSpellActive(bool isActive)
    {
        _spell.SetActive(isActive);
        
    }
   
    private IEnumerator MagicAttackCoroutine()
    {
        canCastSpell = false;
        yield return StartCoroutine(bossEnemyAnimatorController.FirstSpellCoroutine());        
        SetSpellActive(true);
        yield return StartCoroutine(bossEnemyAnimatorController.SecondSpellCoroutine());        
        SetSpellActive(false);
        yield return StartCoroutine(bossEnemyAnimatorController.ThirdSpellCoroutine());       
        canCastSpell = true;
    }
    public void Initialize(BossEnemyAnimatorController bossEnemyAnimatorController)
    {
        this.bossEnemyAnimatorController = bossEnemyAnimatorController;
    }
    
}
