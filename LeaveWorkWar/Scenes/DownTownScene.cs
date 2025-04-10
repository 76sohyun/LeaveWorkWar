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
        mineArt = new List<MineArt>();
        pickstoreArt = new List<PickStoreArt>();
        mineralArt = new List<MineralArt>();
        minestoreArt = new List<MineStoreArt>();
        forestArt = new List<ForestArt>();
        forestgunArt = new List<ForestGunArt>();
        
        townportalArt.Add(new TownPortalArt(ConsoleColor.White, new Vector2(80, 11),new Vector2(80, 12)));
        gameObjects.Add(new Place("Town", 'T', new Vector2(85, 10)));
        mineArt.Add(new MineArt(ConsoleColor.Cyan, new Vector2(50, 11),new Vector2(50, 12)));
        gameObjects.Add(new Place("Mine", 'M', new Vector2(55,10)));
        minestoreArt.Add(new MineStoreArt(ConsoleColor.Magenta, new Vector2(30, 11),new Vector2(30, 12)));
        gameObjects.Add(new Mstore('※', new Vector2(33, 10)));
        forestArt.Add(new ForestArt(ConsoleColor.Green, new Vector2(10, 11), new Vector2(10, 12)));
        gameObjects.Add(new Place("Forest", 'F', new Vector2(15, 10)));
    }

    public override void Enter()
    {
        if (Game.prevSceneName == "Town")
        {
            Game.Player.position = new Vector2(85,10);
            Game.Player.position1 = new Vector2(85,11);
            Game.Player.position2 = new Vector2(85,12);
        }
        else if (Game.prevSceneName == "Mine")
        {
            Game.Player.position = new Vector2(55,10);
            Game.Player.position1 = new Vector2(55,11);
            Game.Player.position2 = new Vector2(55,12);
        }
        else if (Game.prevSceneName == "Forest")
        {
            Game.Player.position = new Vector2(15,10);
            Game.Player.position1 = new Vector2(15,11);
            Game.Player.position2 = new Vector2(15,12);
        }
        
        Game.Player.map = map;
    }
}