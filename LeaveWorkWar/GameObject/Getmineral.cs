namespace LeaveWorkWar;
using LeaveWorkWar.Items;

public class Getmineral : GameObject
{
    private Random random;
    private Item item;
    public static int percent = 0;
    public Getmineral(char symbol, Vector2 position) : base(ConsoleColor.DarkGray, symbol, position, false)
    {
        random = new Random();
       
    }

    public override void Interact(Player player)
    {
        int value= random.Next(0,100);
        int probability = value + percent;
        Thread.Sleep(1000);
       

        if ( probability < 25)
        {
            player.Inventory.Add(new Stone());
        }
        else if ( probability < 45)
        {
            player.Inventory.Add(new Copper());
        }
        else if ( probability < 65)
        {
            player.Inventory.Add(new Iron());
        }
        else if ( probability < 85)
        {
            player.Inventory.Add(new Gold());
        }
        else if ( probability < 95)
        {
            player.Inventory.Add(new Diamond());
        }
        else
        {
            player.Inventory.Add(new Emerald());
        }
    }
}