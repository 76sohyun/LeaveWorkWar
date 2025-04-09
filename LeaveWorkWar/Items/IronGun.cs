namespace LeaveWorkWar.Items;

public class IronGun : Item
{
    public IronGun()
    {
        name = "권총";
        price = 50000;
        description = "공격력을 +1, 거리를 1 늘려준다.";
        symbol = "○";
        
    }

    public override void Use()
    {
        Game.Player.Bullet.Maxdistance += 1;
        Game.Player.Bullet.Damage += 1;
    }
}