namespace LeaveWorkWar.Items;

public class Stone : Item
{
    public Stone()
    {
        name = "돌";
        price = 5;
        description = "길가면 많이 보는 돌맹이";
        symbol = "●";
        amount = 1;
    }

    public override void Use()
    {
        
    }
}