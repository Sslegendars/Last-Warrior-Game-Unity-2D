using System.Collections;
using UnityEngine;

public class BossEnemyAnimatorController : EnemyAnimatorController
{
    private const string castTriggerName = "Cast_Trigger";
    private float castAnimationDuration = 1f;
    private float spellAnimationDuration = 1f;
    private float waitTime = 5f;
    private void Start()
    {
        InitializeComponents();   
    }
    private void InitializeComponents()
    {
        SetAnimationDuration(0.5f, 1.5f);
    }
    public void CastAnimationTrigger()
    {
        SetAnimationTrigger(castTriggerName);
    }
    public IEnumerator FirstSpellCoroutine()
    {
        StopRunAnimation();
        StartIdleAnimation();
        yield return new WaitForSeconds(idleAnimationDuration);
        
        StopIdleAnimation();        
        CastAnimationTrigger();
        yield return new WaitForSeconds(castAnimationDuration);
    }
    public IEnumerator SecondSpellCoroutine()
    {
        yield return new WaitForSeconds(spellAnimationDuration);
    }
    public IEnumerator ThirdSpellCoroutine() 
    {
        StartIdleAnimation();
        yield return new WaitForSeconds(waitTime);
        StopIdleAnimation();
    }
    
}
