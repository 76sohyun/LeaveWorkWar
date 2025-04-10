namespace LeaveWorkWar;

public class ForestArt
{
    public ConsoleColor Color;
    public Vector2 position1;
    public Vector2 position2;


    public ForestArt(ConsoleColor Color, Vector2 Position1, Vector2 Position2)
    {
        this.Color = Color;
        this.position1 = Position1;
        this.position2 = Position2;

    }

    public void Draw()
    {
        Console.SetCursorPosition(position1.x, position1.y);
        Console.ForegroundColor = Color;
        Console.WriteLine("^^^^^^^");
        Console.SetCursorPosition(position2.x, position2.y);
        Console.WriteLine("|  F  |");
        Console.ResetColor();
    }
}