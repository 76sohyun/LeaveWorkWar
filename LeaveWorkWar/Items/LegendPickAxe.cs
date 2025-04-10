namespace LeaveWorkWar.Items;

public class LegendPickAxe : Item
{
    public LegendPickAxe()
    {
        name = "희귀한곡괭이";
        price = 1000000;
        description = "이 세상에서 딱 하나밖에 없는 곡괭이다...";
        symbol = "※";
        
    }

    public override void Use()
    {
        Getmineral.percent += 8;
        Console.WriteLine("행운 8+");
    }
}