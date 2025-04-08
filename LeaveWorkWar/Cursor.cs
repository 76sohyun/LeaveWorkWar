namespace LeaveWorkWar;

public class Cursor
{
    public Vector2 position = new Vector2(36,17);
    
    public void Print()
    {
        Console.SetCursorPosition(position.x, position.y );
        Console.ForegroundColor = ConsoleColor.White;
        Console.Write("▶");
        Console.ResetColor();
    }

    public void Move(ConsoleKey input)
    {
        switch (input)
        {
            case ConsoleKey.UpArrow:
               position.y--;
               if (position.y < 17)
               {
                   position.y = 19;
               }
                break;
            case ConsoleKey.DownArrow:
                position.y++;
                if (position.y > 19)
                {
                    position.y = 17;
                }
                break;
            case ConsoleKey.Enter:
                if (position.y == 17)
                {
                    Game.ChangeScene("Main");
                }
                else if (position.y == 18)
                {
                    Game.ChangeScene("Method");
                }
                else if (position.y == 19)
                {
                    Environment.Exit(0);
                }
                break;
        }
    }
}