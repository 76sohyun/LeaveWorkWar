namespace LeaveWorkWar.Items;

public class IronGun : Item
{
  
    public IronGun()
    {
        name = "권총강화주문서";
        price = 50000;
        description = "경찰이 쓰던 총, 공격력을 +1, 거리를 1 늘려준다.";
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
       Bullet.Maxdistance += 1;
       Game.Player.Bullet.Attack += 1;
       Console.WriteLine("공격력 +1 거리 +1");
   }
}