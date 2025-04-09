namespace LeaveWorkWar.Scenes;

public class TownScene : Standard_Scene
{
    public TownScene()
    {
        name = "Town";
        Console.ForegroundColor = ConsoleColor.Gray;
        mapData = new string[]
        {
            "█                                                                                        █",
            "█                                                                                        █",
            "█                                                                                        █",
            "█                                                                                        █",
            "█                                                                                        █",
            "█                                                                                        █",
            "██████████████████████████████████████████████████████████████████████████████████████████",
            "█                                                                                        █",
            "█                                                                                        █",
            "█                                                                                        █",
            "█                                                                                        █",
            "█                                                                                        █",
            "█                                                                                        █",
            "██████████████████████████████████████████████████████████████████████████████████████████"
        };
        Console.ResetColor();

        map = new bool[14, 90];
        for (int y = 0; y < map.GetLength(0); y++)
        {
            for (int x = 0; x < map.GetLength(1); x++)
            {
                map[y, x] = mapData[y][x] == '█' ? false : true;
            }
        }
        gameObjects = new List<GameObject>();
        portalArt = new List<PortalArt>();
        townportalArt = new List<TownPortalArt>();
        mountainArt = new List<MountainArt>();
        mountaincoinArt = new List<MountaincoinArt>();
        
        portalArt.Add(new PortalArt(ConsoleColor.White, new Vector2(80, 4),new Vector2(80, 5)));
        gameObjects.Add(new Place("DownTown", 'D', new Vector2(85, 3)));
        mountainArt.Add(new MountainArt(ConsoleColor.Green, new Vector2(50, 4), new Vector2(50, 5)));
        gameObjects.Add(new Place("Mountain", 'M', new Vector2(53, 3)));
    }

    public override void Enter()
    {
        if (Game.prevSceneName == "DownTown")
        {
            Game.Player.position = new Vector2(85,3);
            Game.Player.position1 = new Vector2(85,4);
            Game.Player.position2 = new Vector2(85,5);
        }
        else if (Game.prevSceneName == "Mountain")
        {
            Game.Player.position = new Vector2(54,3);
            Game.Player.position1 = new Vector2(54,4);
            Game.Player.position2 = new Vector2(54,5);
        }
        
        Game.Player.map = map;
    }
}