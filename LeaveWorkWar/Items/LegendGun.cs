﻿namespace LeaveWorkWar.Items;

public class LegendGun : Item
{
    public LegendGun()
    {
        name = "저격총";
        price = 500000;
        description = "전설의 총, 공격력을 +10, 거리를 20 늘려준다.";
        symbol = "○";
        
    }

    public override void Use()
    {
        if (Game.Player.Bullet == null)
        {
            Vector2 start = Game.Player.position; // 적절한 위치로 수정
            Vector2 dir = Game.Player.direction;
            Game.Player.Bullet = new Bullet(start, dir, 3);  // 기본 거리 3
        }
        
        Bullet.Maxdistance += 20;
        Game.Player.Bullet.Attack += 10;
        Console.WriteLine("공격력 +10 거리 +20");
    }
}