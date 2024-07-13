using UnityEngine;

public class EnemyController : Controller
{    
    protected Collider2D enemyCollider;
    protected EnemyMovement enemyMovement;
    protected EnemyHealthSystem enemyHealthSystem;
    protected EnemyAttackController enemyAttackController;
    protected PlayerController playerController;

    protected Vector2 lookDirection;
    protected float distanceToPlayer;

    private void FixedUpdate()
    {
        HandleDistanceToPlayerAndLookDirection();
        if (!enemyHealthSystem.Stunned)
        {
            if (IsPlayerAndEnemyAlive())
            {
                HandleEnemyBehavior();

            }
            else
            {
                DisableComponents();
            }

        }
        else
        {
            HandleStunnedState();
        }
    }
    
    public void Initialize
        (
        Collider2D enemyCollider,
        EnemyMovement enemyMovement,
        EnemyHealthSystem enemyHealthSystem,
        EnemyAttackController enemyAttackController,
        PlayerController playerController
        )
    {
        this.enemyCollider = enemyCollider;
        this.enemyMovement = enemyMovement;
        this.enemyHealthSystem = enemyHealthSystem;
        this.enemyAttackController = enemyAttackController;
        this.playerController = playerController;
    }
    protected virtual void HandleEnemyBehavior()
    {
        if (distanceToPlayer > enemyAttackController.AttackStartingDistance && !enemyAttackController.CheckAttackRange)
        {
            
            HandleMovementBehavior();
        }
        else
        {
            
            HandleAttackBehavior();
        }
    }
    protected void HandleMovementBehavior()
    {
        enemyMovement.Move(lookDirection);
        
    }
    private void HandleDistanceToPlayerAndLookDirection()
    {
        HandleLookDirection();
        HandleDistanceToPlayer();
    }
    
    protected void HandleAttackBehavior()
    {
        distanceToPlayer = enemyMovement.DistanceToTargetObject(PlayerTransform());
        if (distanceToPlayer <= enemyAttackController.AttackRange)
        {               
            if (!enemyAttackController.CheckAttackRange)
            {                
                enemyMovement.StopMoving();
                enemyAttackController.Attacking();               
            }          
            
        }
        else
        {
            
            enemyAttackController.StopAttacking(); 
            
        }
    }
    protected virtual void HandleStunnedState()
    {
        enemyMovement.StopMoving();
        enemyHealthSystem.StartHurtBoolTrueToFalseCoroutine();
    }       
    protected bool IsPlayerAndEnemyAlive()
    {
        return playerController != null &&
               playerController.playerHealthSystem.CurrentHealth > 0 &&
               enemyHealthSystem.CurrentHealth > 0;
    }
    
    protected virtual void DisableComponents()
    {
        enemyCollider.enabled = false;
        enemyMovement._rigidbody.simulated = false;       
    }
    
    private Vector2 HandleLookDirection()
    {
        return lookDirection = enemyMovement.LookDirection(PlayerTransform());
    }
    private float HandleDistanceToPlayer()
    {
        return distanceToPlayer = enemyMovement.DistanceToTargetObject(PlayerTransform());
    }
    protected Transform PlayerTransform()
    {
        return playerController.transform;
    }

}
