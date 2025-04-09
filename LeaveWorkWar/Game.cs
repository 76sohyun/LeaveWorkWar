using System.ComponentModel.Design;
using System.Diagnostics;
using LeaveWorkWar.Scenes;

namespace LeaveWorkWar;

public class Game
{
    private static Dictionary<string, BaseScene> sceneDic;
    private static BaseScene curScene;
    public static string prevSceneName;
    
    private static Cursor cursor;
    public static Cursor Cursor{get{return cursor;}}
    
    private static Player player;
    public static Player Player{get{return player;}}
    
    private static bool gameOver;
    public static void Run()
    {
        
        Start();
        while (gameOver == false)
        {
            Console.Clear();
            Console.WriteLine();
            curScene.Render();
            Console.WriteLine();
            curScene.Input();
            Console.WriteLine();
            curScene.Update();
            Console.WriteLine();
            curScene.Result();
        }
        End();
    }
    

    public static void ChangeScene(string sceneName)
    {
        prevSceneName = curScene.name;
        curScene.Exit();
        curScene = sceneDic[sceneName];
        curScene.Enter();
    }

    public static void Start()
    {
        Console.CursorVisible = false;
        gameOver = false;
        cursor = new Cursor();
        
        
        player = new Player();
        
        sceneDic = new Dictionary<string, BaseScene>();
        sceneDic.Add("Title", new TitleScene());
        sceneDic.Add("Main", new MainStoryScene());
        sceneDic.Add("Method", new GameMethodScene());
        sceneDic.Add("Town", new TownScene());
        sceneDic.Add("DownTown", new DownTownScene());
        sceneDic.Add("Mountain", new MountainScene());
        
        curScene = sceneDic["Title"];
        
       
    }

    public static void End()
    {
        
    }
}