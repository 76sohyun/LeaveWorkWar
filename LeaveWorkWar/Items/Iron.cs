namespace LeaveWorkWar.Items;

public class Iron :Item
{
    public Iron()
    {
        name = "철";
        price = 100;
        description = "철은 유용하게 쓸 곳이 많다.";
        symbol = "●";
        amount = 1;
    }

    public override void Use()
    {
        
    }
}