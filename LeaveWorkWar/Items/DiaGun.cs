namespace LeaveWorkWar.Items;

public class DiaGun : Item
{
    public DiaGun()
    {
        name = "샷건강화주문서";
        price = 150000;
        description = "사냥꾼의 총, 공격력을 +4, 거리를 3 늘려준다.";
        symbol = "○";
        
    }

    public override void Use()
    {
        if (Game.Player.Bullet == null)
        {
            Vector2 start = Game.Player.position; 
            Vector2 dir = Game.Player.direction;
            Game.Player.Bullet = new Bullet(start, dir, 3);
        }
        Bullet.Maxdistance += 3;
        Game.Player.Bullet.Attack += 4;
        Console.WriteLine("공격력 +4 거리 +3");
    }
}