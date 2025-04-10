namespace LeaveWorkWar.Items;

public class GoldPickAxe : Item
{
    public GoldPickAxe()
    {
        name = "금곡괭이";
        price = 200000;
        description = "진짜 금일까? 깨물어볼까..?";
        symbol = "※";
        
    }

    public override void Use()
    {
        Getmineral.percent += 4;
        Console.WriteLine("행운 4+");
    }
}