using UnityEngine;

public class EvilItemInitializer : ItemInitializer
{
    protected EvilItem evilItem;
    private void Awake()
    {
        InitializeComponents();
    }
    protected virtual void InitializeComponents()
    {
        evilItem = (EvilItem)item;
    }
}
