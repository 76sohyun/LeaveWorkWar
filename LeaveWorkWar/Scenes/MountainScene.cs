namespace LeaveWorkWar.Scenes;

public class MountainScene : Standard_Scene
{
    public MountainScene()
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
        townportalArt.Add(new TownPortalArt(ConsoleColor.White, new Vector2(1, 4),new Vector2(1,5)));
        gameObjects.Add(new Place("Town", 'T', new Vector2(4, 3)));
    }

    public override void Enter()
    {
        if (Game.prevSceneName == "Town")
        {
            Game.Player.position = new Vector2(4,3);
            Game.Player.position1 = new Vector2(4,4);
            Game.Player.position2 = new Vector2(4,5);
        }
        Game.Player.map = map;
    }
}