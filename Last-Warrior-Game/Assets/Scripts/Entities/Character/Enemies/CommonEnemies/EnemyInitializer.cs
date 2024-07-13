using UnityEngine;

public class EnemyInitializer : CharacterInitializer
{   
    public Collider2D enemyCollider;

    protected HazardHitBox hazardHitBox;
    protected EnemyMovement enemyMovement;
    protected EnemyController enemyController;
    protected EnemyHealthSystem enemyHealthSystem; 
    protected EnemyAttackController enemyAttackController;
    protected EnemyAnimatorController enemyAnimatorController;

    protected PlayerController playerController;

    protected override void InitializeComponents()
    {
        base.InitializeComponents();
        hazardHitBox = (HazardHitBox)hitBox;
        enemyMovement = (EnemyMovement)characterMovement;
        enemyController = (EnemyController)_controller;
        enemyHealthSystem = (EnemyHealthSystem)characterHealthSystem;
        enemyAttackController = (EnemyAttackController)characterAttackController;
        enemyAnimatorController = (EnemyAnimatorController)characterAnimatorController;

        playerController = FindObjectOfType<PlayerController>();

        hazardHitBox.Intialize(playerController);
        enemyMovement.Initialize(enemyAnimatorController);
        enemyController.Initialize(enemyCollider, enemyMovement, enemyHealthSystem, enemyAttackController, playerController);
        enemyAttackController.Initialize(enemyAnimatorController);
        enemyHealthSystem.Initialize(enemyAnimatorController);
    }

}
