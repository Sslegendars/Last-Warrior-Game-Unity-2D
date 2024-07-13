
public class MedicineInitializer : CollectItemInitializer
{
    private Medicine _medicine;

    protected override sealed void InitializeComponents()
    {
        base.InitializeComponents();
        _medicine = (Medicine)collectItem;
    }
}
