namespace LeaveWorkWar.Items;

public class IronPickAxe : Item
{ 
    public IronPickAxe()
    {
        name = "철곡괭이";
        price = 70000;
        description = "스티브가 쓰다만 곡괭이... 좀 닳아있다..";
        symbol = "※";
        
    }

    public override void Use()
    {
        Getmineral.percent += 2;
        Console.WriteLine("행운 2+");
    }
}