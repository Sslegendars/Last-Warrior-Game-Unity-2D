using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInitializer : CharacterInitializer
{
    protected PlayerHitBox playerHitBox;
    protected PlayerMovement playerMovement;
    protected PlayerController playerController;
    protected PlayerHealthSystem playerHealthSystem;
    protected PlayerAttackController playerAttackController;
    protected PlayerAnimatorController playerAnimatorController;
    public GroundCheck groundCheck;  
     
    
    

    protected override void InitializeComponents()
    {
        base.InitializeComponents();
        playerHitBox = (PlayerHitBox)hitBox;
        playerMovement = (PlayerMovement)characterMovement;
        playerController = (PlayerController)_controller;       
        playerHealthSystem = (PlayerHealthSystem)characterHealthSystem;
        playerAttackController = (PlayerAttackController)characterAttackController;
        playerAnimatorController = (PlayerAnimatorController)characterAnimatorController;

        
        playerAttackController.Initialize(playerAnimatorController);
        playerMovement.Intialize(groundCheck, playerAnimatorController);
        playerController.Initialize(playerMovement,playerHealthSystem,playerAttackController);
    }
}
