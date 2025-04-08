using System.ComponentModel.Design;
using LeaveWorkWar.Scenes;

namespace LeaveWorkWar;

public class Game
{
    private static Dictionary<string, BaseScene> sceneDic;
    private static BaseScene curScene;
    public static string prevSceneName;
    
    private static Cursor cursor;
    public static Cursor Cursor{get{return cursor;}}
    
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
        sceneDic = new Dictionary<string, BaseScene>();
        sceneDic.Add("Title", new TitleScene());
        sceneDic.Add("Main", new MainStoryScene());
        sceneDic.Add("Method", new GameMethodScene());
        curScene = sceneDic["Title"];
    }

    public static void End()
    {
        
    }
}