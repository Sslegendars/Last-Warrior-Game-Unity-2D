public class Coin : CollectItem,IHandleCollision
{      
    private const int coinValue = 10;    
    public void HandleCollision()
    {
       if(playerController != null)
       {
            AudioManager.Instance.Play(AudioManager.coinCollectSoundName);
            GameManager.Instance._coin += coinValue;
            GameManager.Instance.UpdateCoinText();
           
            ItemDestroyed();
       }      
    }  
    
}
