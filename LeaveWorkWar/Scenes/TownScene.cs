namespace LeaveWorkWar.Scenes;

public class TownScene : Standard_Scene
{
    public TownScene()
    {
        name = "Town";
        Console.ForegroundColor = ConsoleColor.Gray;
        mapData = new string[]
        {
            "█                                                █",
            "█                                                █",
            "█                                                █",
            "█                                                █",
            "█                                                █",
            "█                                                █",
            "██████████████████████████████████████████████████"
        };
        Console.ResetColor();

        map = new bool[7, 50];
        for (int y = 0; y < map.GetLength(0); y++)
        {
            for (int x = 0; x < map.GetLength(1); x++)
            {
                map[y, x] = mapData[y][x] == '█' ? false : true;
            }
        }
    }

    public override void Enter()
    {
        Game.Player.map = map;
    }
}