namespace LeaveWorkWar;

public class Player
{
    public Vector2 position;
    public void Print()
    {
        Console.SetCursorPosition(position.x, position.y);
        Console.ForegroundColor = ConsoleColor.White;
        Console.Write(" O ");
        Console.Write("/|\"");
        Console.Write(" /\"");
        Console.ResetColor();
    }

    public void Action(ConsoleKey input)
    {
        switch (input)
        {
            case ConsoleKey.UpArrow:
            case ConsoleKey.DownArrow:
            case ConsoleKey.LeftArrow:
            case ConsoleKey.RightArrow:
                Move(input);
                break;
        }
    }

    public void Move(ConsoleKey input)
    {
        Vector2 targetPos = position;
        switch (input)
        {
            case ConsoleKey.UpArrow:
                targetPos.y--;
                break;
            case ConsoleKey.DownArrow:
                targetPos.y++;
                break;
            case ConsoleKey.LeftArrow:
                targetPos.x--;
                break;
            case ConsoleKey.RightArrow:
                targetPos.x++;
                break;
        }
    }

    
}
