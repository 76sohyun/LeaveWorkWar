using System.Net.Mime;

namespace LeaveWorkWar;

public class Bullet
{
    public Vector2 position;
    public Vector2 direction;
    public bool IsShoot = true;
    public int Damage;
    public int Maxdistance;

    public Bullet(Vector2 startp, Vector2 dir, int maxdistance)
    {
        position = startp;
        direction = dir;
        Damage = 2;
        Maxdistance = 3;
    }

    public void Update()
    {
        position += direction;
        if (position.x > 90 || position.x < 0||direction.x > Maxdistance)
        {
            IsShoot = false;
        }
    }

    public void Draw()
    {
        if (IsShoot)
        {
            Console.SetCursorPosition(position.x, position.y);
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.Write("●");
            Console.ResetColor();
        }
        
    }
    
    
}