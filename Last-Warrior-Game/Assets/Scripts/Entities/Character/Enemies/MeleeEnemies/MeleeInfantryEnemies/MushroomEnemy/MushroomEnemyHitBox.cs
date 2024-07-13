
public class MushroomEnemyHitBox : HazardHitBox
{
    protected override void Start()
    {
        base.Start();
        damageAmount = 10;
        pushForce = 10;
    }

    
}
