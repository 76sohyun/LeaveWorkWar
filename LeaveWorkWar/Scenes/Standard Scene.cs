namespace LeaveWorkWar.Scenes;

public abstract class Standard_Scene : BaseScene
{
    protected string[] mapData;
    protected bool[,] map;
    private ConsoleKey input;
    
    public override void Render()
    {
        PrintMap();
        Game.Player.Print();
    }

    public override void Input()
    {
        input = Console.ReadKey(true).Key;
    }

    public override void Update()
    {
        Game.Player.Action(input);
    }

    public override void Result()
    {
        
    }

    private void PrintMap()
    {
        Console.SetCursorPosition(0, 0);
        for (int y = 0; y < map.GetLength(0); y++)
        {
            for (int x = 0; x < map.GetLength(1); x++)
            {
                if (map[y, x] == true)
                {
                    Console.Write(' ');
                }
                else
                {
                    Console.Write('█');
                }
            }
            Console.WriteLine();
        }
                
    }
}