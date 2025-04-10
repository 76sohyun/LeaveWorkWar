namespace LeaveWorkWar;

public class PickStore
{
    private List<Item> items;
    private Stack<string> stack;
    private int selectIndex;
    private Inventory inventory;
    private Random random;

    public Inventory Inventory
    {
        get { return inventory; }
        set { inventory = value; }
    }

    public PickStore()
    {
        items = new List<Item>();
        stack = new Stack<string>();
        random = new Random();
    }

    public void Buy(Player player, Item item)
    {
        
    }

    public void Open(Player player)
    {
        stack.Push("Menu");

        while (stack.Count > 0)
        {
            Console.Clear();
            switch (stack.Peek())
            {
                case "Menu": Menu(); break;
                case "UseMenu": UseMenu(); break;
                case "UseConfirm": UseConfirm(player); break;
            }
        }
    }

    private void Menu()
    {
        PrintAll();
        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine("B. 구매하기");
        Console.WriteLine();
        Console.WriteLine("C. 뒤로가기");

        ConsoleKey input = Console.ReadKey(true).Key;
        switch (input)
        {
            case ConsoleKey.B:
                stack.Push("UseMenu");
                break;
            case ConsoleKey.C:
                stack.Pop();
                break;
        }
    }

    private void UseMenu()
    {
        PrintAll();

        Console.WriteLine("뽑기권을 구매하시겠습니까? 1번키를 누르세요.");
        Console.WriteLine("뒤로가기는 C키를 눌러주세요.");

        ConsoleKey input = Console.ReadKey(true).Key;
        if (input == ConsoleKey.C)
        {
            stack.Pop();
        }
        else if(input == ConsoleKey.D1)
        {
            stack.Push("UseConfirm");
        }
        else
        {
            Util.PressAnyKey("정확한 버튼을 누르세요...");
        }
    }

    private void UseConfirm(Player player)
    {
        Console.WriteLine("████████████████████████████████████████████████████████████████████████████████████████████████");
        Console.WriteLine("                                퇴근권 뽑기를 진행합니다...(y/n)                                    ");
        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine("                                         <당첨결과>                                              ");

        ConsoleKey input = Console.ReadKey(true).Key;
        switch (input)
        {      case ConsoleKey.Y:
                if (player.Money >= 100000)
                {
                    player.Money -= 100000;
                    int value= random.Next(0,100);
                    Thread.Sleep(1000);

                    if (value < 33)
                    {
                        Console.WriteLine("틔근권");
                        Console.WriteLine("어잇쿠.... 퇴근 실패!!");
                    }
                    else if (value < 66)
                    {
                        Console.WriteLine("퇴군권");
                        Console.WriteLine("어잇쿠.... 퇴근 실패!!");
                    }
                    else if (value < 99)
                    {
                        Console.WriteLine("퇴근귄");
                        Console.WriteLine("어잇쿠.... 퇴근 실패!!");
                    }
                    else // value == 99
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("퇴근권");
                        Console.ResetColor();
                        Console.WriteLine("이... 이럴수가 퇴근을 하다니!!!!!");
                        Game.GameClear();
                    }

                    Util.PressAnyKey("아무키나 누르세요..."); 
                   
                }
                else
                {
                    Util.PressAnyKey("돈이 부족합니다!");
                }
                stack.Pop();
                break;
            case ConsoleKey.N:
                stack.Pop();
                break;
        }
        Console.WriteLine("████████████████████████████████████████████████████████████████████████████████████████████████");

    }


public void PrintAll()
    {
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine("                                            ▶퇴근권 뽑기◀                                                 ");
        Console.WriteLine("████████████████████████████████████████████████████████████████████████████████████████████████");
        Console.ResetColor();
        Console.WriteLine("1. 퇴근권뽑기권 - 100000원 + 엄청 소듕한 뽑기권이다.");
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine("████████████████████████████████████████████████████████████████████████████████████████████████");
        Console.ResetColor();
    }
}