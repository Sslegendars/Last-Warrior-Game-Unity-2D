using UnityEngine;
public class CharacterInitializer : MonoBehaviour
{
    public HitBox hitBox;
    public CharacterMovement characterMovement;
    public Rigidbody2D _rigidbody;
    public CharacterAnimatorController characterAnimatorController;
    public Animator _animator;
    public CharacterHealthSystem characterHealthSystem;
    public CharacterAttackController characterAttackController;
    public Controller _controller;

    
    
    protected virtual void Awake()
    {
        InitializeComponents();

    }
    protected virtual void InitializeComponents()
    {
        characterMovement.Initialize(_rigidbody);
        characterAnimatorController.Initialize(_animator);       
        characterHealthSystem.Initialize(characterAnimatorController);
        _controller.Initialize(characterHealthSystem, characterMovement, characterAttackController);
    }
}
