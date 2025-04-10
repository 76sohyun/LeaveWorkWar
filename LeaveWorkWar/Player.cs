using System.ComponentModel;
using LeaveWorkWar.Items;

namespace LeaveWorkWar;

public class Player
{
    public Vector2 position = new Vector2(1,3);
    public Vector2 position1 = new Vector2(1,4);
    public Vector2 position2 = new Vector2(1,5);
    public bool[,] map;
    public Vector2 direction = new Vector2(1, 0);
    private int money;
    public int Money { get { return money; } set { money = value; } }

    private int curHp;
    public int CurHp {get { return curHp; } set{ curHp = value; } }
    private int maxHp;
    public int MaxHp {get { return maxHp; }}
    
    private Inventory inventory;
    public Inventory Inventory { get { return inventory; }}
    
    public TownStore townStore;
    public PickStore pickStore;
    public MineStore mineStore;
    
    private Bullet bullet;
    public Bullet Bullet { get { return bullet; } set{ bullet = value; } }

    public Player()
    {
        maxHp = 10;
        curHp = maxHp;
        inventory = new Inventory();
        townStore = new TownStore();
        pickStore = new PickStore();
        mineStore = new MineStore();
        money = 1000000;
    }
    
    public bool IsDead()
    {
        return curHp == 0;
    }

    public void Heal(int amount)
    {
        curHp += amount;
        if (curHp > maxHp) curHp = maxHp;
    }

    public void HpPrint()
    {
        Console.SetCursorPosition(50, map.GetLength(0) + 2);
        Console.WriteLine("------------------채력-----------------");
        Console.SetCursorPosition(50, map.GetLength(0) + 3);
        for (int i = 0; i < curHp; i++)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("♥   ");
        }
        Console.ResetColor();
        Console.SetCursorPosition(50, map.GetLength(0) + 4);
        Console.WriteLine("---------------------------------------");
    }
    public void Print()
    {
        Console.SetCursorPosition(position.x, position.y);
        Console.ForegroundColor = ConsoleColor.DarkGreen;
        Console.WriteLine(" O");
        Console.SetCursorPosition(position1.x, position1.y);
        Console.WriteLine("/|\\");
        Console.SetCursorPosition(position2.x, position2.y);
        Console.WriteLine(" /\\");
        Console.ResetColor();
    }

    public void Action(ConsoleKey input)
    {
        switch (input)
        {
            case ConsoleKey.LeftArrow:
                Move(input);
                direction.x = -1;
                break;
            case ConsoleKey.RightArrow:
                Move(input);
                direction.x = 1;
                break;
            case ConsoleKey.I:
                Inventory.Open();
                break;
            case ConsoleKey.Spacebar:
                Shoot();
                break;

        }
    }


    public void Move(ConsoleKey input)
    {
        Vector2 targetPos = position;
        Vector2 targetPos1 = position1;
        Vector2 targetPos2 = position2;
        switch (input)
        {
            case ConsoleKey.LeftArrow:
                targetPos.x--;
                targetPos1.x--;
                targetPos2.x--;
                break;
            case ConsoleKey.RightArrow:
                targetPos.x++;
                targetPos1.x++;
                targetPos2.x++;
                break;
        }
        
        if (map[targetPos.y, targetPos.x] == true && map[targetPos.y, targetPos.x + 2] == true)
        {
            position = targetPos;
            position1 = targetPos1;
            position2 = targetPos2;
        } 
    }

    public void MoneyPrint()
    {
        Console.WriteLine("--------------------지갑--------------------");
        if (money == 0)
        {
            Console.WriteLine("                     0원");
        }
        else
        {
            Console.WriteLine($"                 {money}원");
        }
        Console.WriteLine("--------------------------------------------");
    }
    

    public void Shoot()
    {
        Vector2 startPos = new Vector2();
        startPos.x = position1.x + direction.x * 2;
        startPos.y = position1.y;
        
        bullet = new Bullet(startPos, direction, 3);
        int count = 0;
        while (count < Bullet.Maxdistance)
        {
            bullet.Update();
            bullet.Draw();
            count++;            
        }
    }

    public void TakeDamage(int damage)
    {
        curHp -= damage;
        
        if (curHp <= 0)
        {
            Game.GameOver("체력이 0이 되어 사망하였습니다...");
        }
    }

    
    
}
