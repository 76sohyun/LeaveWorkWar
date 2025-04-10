namespace LeaveWorkWar.Scenes;

public class GameMethodScene : BaseScene
{
    private ConsoleKey input;

    public GameMethodScene()
    {
        name = "Main";

    }

    public override void Render()
    {
        Console.WriteLine("방향 조작키 : 방향키 왼쪽과 오른쪽");
        Console.WriteLine();
        Console.WriteLine("상호작용 키 : F");
        Console.WriteLine();
        Console.WriteLine("총 쏘는 키 : Space Bar");
        Console.WriteLine();
        Console.WriteLine("뒤로가려면 엔터키를 누르세요.");
    }

    public override void Input()
    {
        input = Console.ReadKey().Key;
    }


    public override void Update()
    {

    }

    public override void Result()
    {
        switch (input)
        {
            case ConsoleKey.Enter:
                Game.ChangeScene("Title");
                break;
        }
    }
}