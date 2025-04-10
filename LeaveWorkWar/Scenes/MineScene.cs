namespace LeaveWorkWar.Scenes;

public class MineScene : Standard_Scene
{
    public MineScene() 
    {
        name = "Mountain";
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
        
        portalArt.Add(new PortalArt(ConsoleColor.White, new Vector2(1, 4),new Vector2(1,5)));
        gameObjects.Add(new Place("DownTown", 'D', new Vector2(5, 3)));
        mineralArt.Add(new MineralArt(ConsoleColor.Cyan, new Vector2(70, 1), new Vector2(70, 2)));
        gameObjects.Add(new MineGetMineral(new Vector2(75,3)));
        
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