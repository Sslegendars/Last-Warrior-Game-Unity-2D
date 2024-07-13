using UnityEngine;

public class BossEnemyBurnDamageHitBox : BossEnemyHitBox
{
    [SerializeField]
    private GameObject playerBurnParticle;
    private const int damagePerSecond = 5;
    private bool isBurning = false;  
    protected override void InitializeComponents()
    {
        base.InitializeComponents();
        pushForce = 0;
        playerBurnParticle.SetActive(false);
       
    }

    protected override void ApplyDamageAndPushForce(Collider2D other, Rigidbody2D otherRigidbody)
    {
        if (playerController.playerHealthSystem != null)
        {
            base.ApplyDamageAndPushForce(other, otherRigidbody);
            StartBurning();
        }
        else
        {
            StopBurning();
        }
    }

    private void StartBurning()
    {
        isBurning = true;
        playerBurnParticle.SetActive(true);
        InvokeRepeating(nameof(DealDamage), 1f, 1f);
        Invoke(nameof(StopBurning), 3f);
    }
    private void StopBurning()
    {
        isBurning = false;
        CancelInvoke(nameof(DealDamage));
        playerBurnParticle.SetActive(false);
        AudioManager.Instance.Stop(AudioManager.playerFireParticleSoundName);
    }

    private void DealDamage()
    {
        if (playerController.playerHealthSystem != null && isBurning)
        {
            playerController.playerHealthSystem.SetDamage(damagePerSecond);

            if (playerBurnParticle != null && playerController.playerHealthSystem.CurrentHealth > 0)
            {
                AudioManager.Instance.Play(AudioManager.playerFireParticleSoundName);
            }
        }
    }

    
}
