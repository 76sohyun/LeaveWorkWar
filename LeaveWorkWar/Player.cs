namespace LeaveWorkWar;

public class Player
{
    public Vector2 position = new Vector2(1,3);
    public Vector2 position1 = new Vector2(1,4);
    public Vector2 position2 = new Vector2(1,5);

    public bool[,] map;
    public void Print()
    {
        Console.SetCursorPosition(position.x, position.y);
        Console.ForegroundColor = ConsoleColor.White;
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
            case ConsoleKey.RightArrow:
                Move(input);
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
        
        if (map[targetPos.y, targetPos.x] == true)
        {
            position = targetPos;
            position1 = targetPos1;
            position2 = targetPos2;
        } 
    }
}
