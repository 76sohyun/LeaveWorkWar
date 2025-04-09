namespace LeaveWorkWar.Scenes;

public class DownTownScene : Standard_Scene
{
    public DownTownScene()
    {
        name = "DownTown";
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
        townportalArt = new List<TownPortalArt>();
        portalArt = new List<PortalArt>();
        mountainArt = new List<MountainArt>();
        mountaincoinArt = new List<MountaincoinArt>();
        townstoreArt = new List<TownStoreArt>();
        
        townportalArt.Add(new TownPortalArt(ConsoleColor.White, new Vector2(80, 11),new Vector2(80, 12)));
        gameObjects.Add(new Place("Town", 'T', new Vector2(85, 10)));
    }

    public override void Enter()
    {
        if (Game.prevSceneName == "Town")
        {
            Game.Player.position = new Vector2(85,10);
            Game.Player.position1 = new Vector2(85,11);
            Game.Player.position2 = new Vector2(85,12);
        }
        
        Game.Player.map = map;
    }
}