using System.Net.Mime;

namespace LeaveWorkWar;

public class Bullet
{
    public Vector2 position;
    public Vector2 direction;
    public bool IsShoot = true;
    public int Attack {get;set;}
    public static int Maxdistance =3;

    public Bullet(Vector2 startp, Vector2 dir,int Maxdistance)
    {
        position = startp;
        direction = dir;
        Attack = 2;
        
    }

    public void Update()
    {
        position.x = position.x + direction.x;
        position.y = position.y + direction.y;
        
        if (position.x > 90 || position.x < 0)
            IsShoot = false;
        
    }

    public void Draw()
    {
        if (IsShoot)
        {
            Console.SetCursorPosition(position.x, position.y);
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.Write("●");
            Console.ResetColor();
        
            Thread.Sleep(300);
        
            Console.Write("\b");
            Console.Write(" ");
        }    
    }
    
    
}