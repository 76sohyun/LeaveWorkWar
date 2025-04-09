using LeaveWorkWar.Items;

namespace LeaveWorkWar;

public class TownStore
{
    private List<Item> items;
    private Stack<string> stack;
    private int selectIndex;
    private Inventory inventory;

    public Inventory Inventory
    {
        get { return inventory; }
        set { inventory = value; }
    }

    public TownStore()
    {
        items = new List<Item>();
        stack = new Stack<string>();

        items.Add(new Potion());
        items.Add(new IronGun());
        items.Add(new DiaGun());
        items.Add(new LegendGun());
    }

    public void Buy(Player player, Item item)
    {
        if (player.Money >= item.price)
        {
            player.Inventory.Add(item);
            player.Money -= item.price;
            item.amount++;
        }
        else
        {
            {
                Util.PressAnyKey("돈이 부족합니다.");
            }
        }

        if (item.name == "IronGun"|| item.name == "DiaGun" || item.name == "LegendGun")
        {
            items.Remove(item);
        }
    }

    public void Sell(Player player, Item item)
    {
        player.Inventory.Remove(item);
        player.Money += item.price;
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

        Console.WriteLine("구매할 아이템을 선택해주세요.");
        Console.WriteLine("뒤로가기는 C키를 눌러주세요.");

        ConsoleKey input = Console.ReadKey(true).Key;
        if (input == ConsoleKey.C)
        {
            stack.Pop();
        }
        else
        {
            int select = (int)input - (int)ConsoleKey.D1;
            if (select < 0 || items.Count <= select)
            {
                Util.PressAnyKey("범위 내의 아이템을 선택하세요.");
            }
            else
            {
                selectIndex = select;
                stack.Push("UseConfirm");
            }
        }
    }

    private void UseConfirm(Player player)
    {
        Item selectItem = items[selectIndex];
        Console.WriteLine("{0} 을/를 구매하시겠습니까? (y/n)", selectItem.name);

        ConsoleKey input = Console.ReadKey(true).Key;
        switch (input)
        {      case ConsoleKey.Y:
                if (player.Money >= selectItem.price)
                {
                    Buy(player, selectItem);
                    Util.PressAnyKey($"{selectItem.name} 을/를 구매했습니다.");
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
    }


public void PrintAll()
    {
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine("                                            ♧마을 상점♧                                                 ");
        Console.WriteLine("████████████████████████████████████████████████████████████████████████████████████████████████");
        Console.ResetColor();
        for (int i = 0; i < items.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {items[i].symbol} {items[i].name} - {items[i].price}원 + {items[i].description} +");
        }
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine("████████████████████████████████████████████████████████████████████████████████████████████████");
        Console.ResetColor();
    }
}