using UnityEngine;

public class Controller : MonoBehaviour
{
    protected CharacterHealthSystem characterHealthSystem;
    protected CharacterMovement characterMovement;
    protected CharacterAttackController characterAttackController;   
   
    public void Initialize(CharacterHealthSystem characterHealthSystem, CharacterMovement characterMovement, CharacterAttackController characterAttackController)
    {
        this.characterHealthSystem = characterHealthSystem;
        this.characterMovement = characterMovement;
        this.characterAttackController = characterAttackController;
    }
   
    protected bool CheckDeadState()
    {
        return !characterHealthSystem.IsDead;
    }
}
