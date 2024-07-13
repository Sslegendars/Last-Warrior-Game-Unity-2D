
public class CoinInitializer : CollectItemInitializer
{
    private Coin _coin;

    protected override sealed void InitializeComponents()
    {
        base.InitializeComponents();
        _coin = (Coin)collectItem;
    }
}
