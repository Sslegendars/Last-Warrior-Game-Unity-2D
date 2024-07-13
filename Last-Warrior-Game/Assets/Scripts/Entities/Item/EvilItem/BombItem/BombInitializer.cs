
public class BombInitializer : EvilItemInitializer
{    
    private Bomb _bomb;

    protected override sealed void InitializeComponents()
    {
        base.InitializeComponents();
        _bomb = (Bomb)evilItem;       
        
    }
}
