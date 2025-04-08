namespace LeaveWorkWar.Scenes;

public class TitleScene : BaseScene
{
    public Vector2 position;
    private ConsoleKey input;
    public TitleScene()
    {
        name = "Title";
    }
    public override void Render()
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        Console.WriteLine("░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░");
        Console.WriteLine("░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░");
        Console.WriteLine("░░░░██████████░░░░██░░░░░██████████████░░░░░░██████████░░░░░░██░░░░██████████░░██░░██░░░░");
        Console.WriteLine("░░░░██░░░░░░░░░░░░██░░░░░░░░░░░░░░░░░██░░░░░░░░░░██░░░░░░░░░░██░░░░░░░░██░░░░░░██░░██░░░░");
        Console.WriteLine("░░░░██████████░░░░██░░░░░░░░░░░░░░░░░██░░░░░░░░██░░██░░░░██████░░░░░░██░░██░░░░██████░░░░");
        Console.WriteLine("░░░░██░░░░░░░░░░░░██░░░░░░░░░░░░░░░░░██░░░░░░██░░░░░░██░░░░░░██░░░░██░░░░░░██░░██░░██░░░░");
        Console.WriteLine("░░░░██████████░░░░██░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░██░░░░░░░░░░░░░░░░██░░██░░░░");
        Console.WriteLine("░░░░░░░░░░░░░░░░░░██░░░░██████████████████░░░░░░░░░░░░░░░░░░░██░░░░░░░░░░░░░░░░░░░░░░░░░░");
        Console.WriteLine("░░░░░░░░██░░░░░░░░██░░░░░░░░░░░░░░░░░░░░░░░░░░░░░██░░░░░░░░░░░░░░░░░░░░░░████████░░░░░░░░");
        Console.WriteLine("░░░░░░░░██░░░░░░░░██░░░░░░██░░░░░░░░░░░░░░░░░░░░░██░░░░░░░░░░░░░░░░░░░░██░░░░░░░░██░░░░░░");
        Console.WriteLine("░░██████████████░░██░░░░░░██░░░░░░░░░░░░░░░░░░░░░██░░░░░░░░░░░░░░░░░░░░██░░░░░░░░██░░░░░░");
        Console.WriteLine("░░░░░░░░░░░░░░░░░░██░░░░░░██████████████░░░░██░░░██████████████░░░░░░░░░░████████░░░░░░░░");
        Console.WriteLine("░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░");
        Console.WriteLine("░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░");
        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine("                                         시작하기                                          ");
        Console.WriteLine("                                         게임방법                                          ");
        Console.WriteLine("                                         종료하기                                          ");
    }

    public override void Input()
    {
        input = Console.ReadKey(true).Key;
    }

    public override void Update()
    {
        Game.Cursor.Move(input);
    }

    public override void Result()
    {
        
    }
}