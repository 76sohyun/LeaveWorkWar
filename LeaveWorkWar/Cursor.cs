namespace LeaveWorkWar;

public class Cursor
{
    private Vector2 position;
    private ConsoleKey input;
    
    public void Print()
    {
        Console.SetCursorPosition(36, 17 );
        Console.ForegroundColor = ConsoleColor.White;
        Console.Write("▶");
        Console.ResetColor();
    }

    public void Move(ConsoleKey input)
    {
        Vector2 target = position;
        switch (input)
        {
            case ConsoleKey.UpArrow:
                target.y--;
                break;
            case ConsoleKey.DownArrow:
                target.y++;
                break;
            case ConsoleKey.Enter:
                if (target.y == 17)
                {
                    Game.ChangeScene("Main");
                }
                else if (target.y == 18)
                {
                    Game.ChangeScene("Method");
                }
                else if (target.y == 19)
                {
                    Environment.Exit(0);
                }
                else
                {
                    if (target.y < 17)
                    {
                        target.y = 19;
                    }
                    else if (target.y > 19)
                    {
                        target.y = 17;
                    }
                }
                break;
        }
    }
}