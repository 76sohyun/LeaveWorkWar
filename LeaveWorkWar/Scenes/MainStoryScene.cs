namespace LeaveWorkWar.Scenes;

public class MainStoryScene : BaseScene
{
    private ConsoleKey input;
    public MainStoryScene()
    {
        name = "Main";
        
    }
    public override void Render()
    {
     // Util.Print("▷              오늘은 게임 회사에 첫 출근하는 날!!><                                 ",ConsoleColor.White, 1000);
     // Console.WriteLine();
     // Util.Print("▷              직원들이 다 눈이 충혈되어 있다... 뭐지?                                ",ConsoleColor.White, 1000);
     // Console.WriteLine();
     // Util.Print("▷              그렇게 열심히 일하다가 퇴근 시간이 다 되어 짐을 싸려던 그 때....           ",ConsoleColor.White, 1000);
     // Console.WriteLine();
     // Util.Print("▷              컴퓨터에 이상한 창이 뜬다...           ",ConsoleColor.White, 1000);
     // Console.WriteLine();
     // Util.Print("▷              \"퇴근하고 싶습니까? 퇴근권을 얻으세요.\"           ",ConsoleColor.Red, 1000);
     // Console.WriteLine();
     // Util.Print("▷              다들 눈이 충혈된 이유가 있었다..            ",ConsoleColor.White, 1000);
     // Console.WriteLine();
     // Util.Print("▷              퇴근 시간이 되었는데도 퇴근을 못해서 그런 것이다.         ",ConsoleColor.White, 1000);
     // Console.WriteLine();
     // Util.Print("▷              퇴근하는 방법은 컴퓨터에 뜬 퇴근 전쟁 게임에서 퇴근권을 얻는 것... !!!         ",ConsoleColor.White, 1000);
     // Console.WriteLine();
     // Util.Print("▷              10만원을 모아 퇴근권 뽑기의 행운의 주인공이 될 것인가..          ",ConsoleColor.Yellow, 1000);
     // Console.WriteLine();
     // Util.Print("▷              1억을 모아 노가다를 하며 퇴근권을 얻을 것인가...          ",ConsoleColor.Yellow, 1000);
     // Console.WriteLine();
     // Util.Print("▷              꼭 퇴근을 해보자!!!!!!!! Let's Go 퇴근전쟁        ",ConsoleColor.White, 1000);
     // Console.WriteLine();
     // Console.WriteLine();
     // Console.WriteLine();
        Console.WriteLine("               <시작하려면 J 키를 눌러주세요>                  ");
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
            case ConsoleKey.J:
                Game.ChangeScene("Town");
                break;
        }
    }
}