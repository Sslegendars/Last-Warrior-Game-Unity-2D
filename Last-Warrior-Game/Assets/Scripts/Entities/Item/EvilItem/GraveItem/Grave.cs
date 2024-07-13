using System.Collections;
using UnityEngine;

public class Grave : EvilItem,IHandleCollision
{   
    [Header("Enemy Spawn Object")]
    [SerializeField] 
    private GameObject skeletonEnemy;

    private int currentHit = 0;   
    private bool hitApplied = false;   
    private const int maxHits = 5;
    private GraveAnimatorController graveAnimatorController;  
    protected override void Start()
    {
        base.Start();        
        StartCoroutine(DestroyGameObject());
        
    }   
    public void HandleCollision()
    {
        if (!hitApplied)
        {
            currentHit++;
            if (currentHit >= maxHits)
            {
                StopCoroutine(DestroyGameObject());
                ItemDestroyed();
            }

            graveAnimatorController.TakeHitAnimation();
            hitApplied = true;
        }
        
    }
   
    private void OnTriggerExit2D(Collider2D other)
    {
        if(other.CompareTag(triggerName))
        {
            hitApplied = false;
        }
    }  
    IEnumerator DestroyGameObject()
    {
        destroyDelay = 10f;
        yield return new WaitForSeconds(destroyDelay);
        
        if(currentHit < maxHits)
        {

            AudioManager.Instance.Play(AudioManager.graveSoundName);
            Instantiate(skeletonEnemy, transform.position, Quaternion.identity);
            ItemDestroyed();
        }       
       
    }
    protected override sealed void InitializeComponents()
    {
        base.InitializeComponents();
        triggerName = "Player_HitBox";
    }
    public void Initialize(GraveAnimatorController graveAnimatorController)
    {
        this.graveAnimatorController = graveAnimatorController;
    }
}

