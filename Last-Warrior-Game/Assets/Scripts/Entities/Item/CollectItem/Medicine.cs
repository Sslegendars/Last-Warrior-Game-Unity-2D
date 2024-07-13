
public class Medicine : CollectItem,IHandleCollision
{
    public int healAmount = 20;
     
    public void HandleCollision()
    {
        if (playerController.playerHealthSystem != null)
        {
            if (playerController.playerHealthSystem.CurrentHealth < playerController.playerHealthSystem.MaxHealth)
            {
                playerController.playerHealthSystem.Heal(healAmount);                
                ItemDestroyed();

            }

        } 
        

    }
}
