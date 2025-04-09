namespace LeaveWorkWar.Items;

public class DiaGun : Item
{
    public DiaGun()
    {
        name = "샷건";
        price = 150000;
        description = "공격력을 +4, 거리를 3 늘려준다.";
        symbol = "○";
        
    }

    public override void Use()
    {
        Game.Player.Bullet.Maxdistance += 3;
        Game.Player.Bullet.Damage += 4;
    }
}