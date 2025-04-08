namespace LeaveWorkWar;

public class TownPortalArt
{
    public ConsoleColor Color;
    public Vector2 position1;
    public Vector2 position2;
    

    public TownPortalArt(ConsoleColor Color, Vector2 Position1, Vector2 Position2)
    {
        this.Color = Color;
        this.position1 = Position1;
        this.position2 = Position2;
        
    }

    public void Draw()
    {
        Console.SetCursorPosition(position1.x, position1.y);
        Console.ForegroundColor = Color;
        Console.WriteLine(" ㅡㅡㅡㅡ");
        Console.SetCursorPosition(position2.x, position2.y);
        Console.WriteLine("| Town |");
        Console.ResetColor();
    }
}