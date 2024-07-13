using UnityEngine;
public class GraveInitializer : EvilItemInitializer
{
    public Animator _animator;
    public GraveAnimatorController graveAnimatorController;
    private Grave _grave;

    protected override sealed void InitializeComponents()
    {
        base.InitializeComponents();
        _grave = (Grave)evilItem;
        graveAnimatorController.Initialize(_animator);
        _grave.Initialize(graveAnimatorController);

    }
}
