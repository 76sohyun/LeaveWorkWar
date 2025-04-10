namespace LeaveWorkWar.Scenes;

public abstract class Standard_Scene : BaseScene
{
    protected string[] mapData;
    protected bool[,] map;
    private ConsoleKey input;

    protected List<GameObject> gameObjects;
    protected List<PortalArt> portalArt;
    protected List<TownPortalArt> townportalArt;
    protected List<MountainArt> mountainArt;
    protected List<MountaincoinArt> mountaincoinArt;
    protected List<TownStoreArt> townstoreArt;
    protected List<PickStoreArt> pickstoreArt;
    protected List<MineArt> mineArt;
    protected List<MineralArt> mineralArt;
    protected List<MineStoreArt> minestoreArt;

    public bool isPress;
    public override void Render()
    {
        PrintMap();
        foreach (GameObject go in gameObjects)
        {
            go.Print();
        }

        foreach (PortalArt ar in portalArt)
        {
            ar.Draw();
        }

        foreach (TownPortalArt tr in townportalArt)
        {
            tr.Draw();
        }

        foreach (MountainArt mr in mountainArt)
        {
            mr.Draw();
        }

        foreach (MountaincoinArt mc in mountaincoinArt)
        {
            mc.Draw();
        }

        foreach (TownStoreArt st in townstoreArt)
        {
            st.Draw();
        }

        foreach (PickStoreArt p in pickstoreArt)
        {
            p.Draw();
        }

        foreach (MineArt mr in mineArt)
        {
            mr.Draw();
        }

        foreach (MineralArt mrr in mineralArt)
        {
            mrr.Draw();
        }

        foreach (MineStoreArt ms in minestoreArt)
        {
            ms.Draw();
        }
        
        Game.Player.Print();
        
        Console.SetCursorPosition(0, map.GetLength(0) + 2);
        Game.Player.MoneyPrint();
        Game.Player.HpPrint();
        Console.SetCursorPosition(0, map.GetLength(0) + 5);
        Game.Player.Inventory.PrintAll();
    }

    public override void Input()
    {
        input = Console.ReadKey(true).Key;
        if (isPress == true)
        {
            Thread.Sleep(10);
            isPress = false;
        }
    }

    public override void Update()
    {
        Game.Player.Action(input);
        
    }

    public override void Result()
    {
        foreach (GameObject go in gameObjects)
        {
            if (Game.Player.position == go.position || Game.Player.position1 == go.position || Game.Player.position2 == go.position)
            {
                switch (input)
                {
                    case ConsoleKey.F:
                        go.Interact(Game.Player);
                        isPress = true;
                        break;
                }
                if (go.isOnce == true)
                {
                    gameObjects.Remove(go);
                }
                break;
            }
        }
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