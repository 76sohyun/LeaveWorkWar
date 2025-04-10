namespace LeaveWorkWar;

public class ForestGunArt
{
    public ConsoleColor Color;
    public Vector2 position1;
    public Vector2 position2;


    public ForestGunArt(ConsoleColor Color, Vector2 Position1)
    {
        this.Color = Color;
        this.position1 = Position1;
        

    }

    public void Draw()
    {
        Console.SetCursorPosition(position1.x, position1.y);
        Console.ForegroundColor = Color;
        Console.WriteLine("과녁에 총을 쏴볼까?");
        Console.ResetColor();
    }
}