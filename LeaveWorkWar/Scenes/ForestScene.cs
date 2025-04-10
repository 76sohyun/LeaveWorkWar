namespace LeaveWorkWar.Scenes;

public class ForestScene : Standard_Scene
{
    
    public ForestScene() 
    {
       
        name = "Forest";
        Console.ForegroundColor = ConsoleColor.DarkGreen;
        mapData = new string[]
        {
            "█                                                                                        █",
            "█                                                                                        █",
            "█                                                                                        █",
            "█                                                                                        █",
            "█                                                                                        █",
            "█                                                                                        █",
            "██████████████████████████████████████████████████████████████████████████████████████████",
        };
        Console.ResetColor();

        map = new bool[7, 90];
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
        townstoreArt = new List<TownStoreArt>();
        mineArt = new List<MineArt>();
        pickstoreArt = new List<PickStoreArt>();
        mineralArt = new List<MineralArt>();
        minestoreArt = new List<MineStoreArt>();
        forestArt = new List<ForestArt>();
        forestgunArt = new List<ForestGunArt>();
        
        portalArt.Add(new PortalArt(ConsoleColor.White, new Vector2(1, 4),new Vector2(1,5)));
        gameObjects.Add(new Place("DownTown", 'D', new Vector2(5, 3)));
        gameObjects.Add(new Target(new Vector2(80, 4) ,100));
        forestgunArt.Add(new ForestGunArt(ConsoleColor.DarkRed, new Vector2(30,2)));
        
    }
    

    public override void Enter()
    {
        if (Game.prevSceneName == "DownTown")
        {
            Game.Player.position = new Vector2(5,3);
            Game.Player.position1 = new Vector2(5,4);
            Game.Player.position2 = new Vector2(5,5);
        }
        Game.Player.map = map;
    }
}