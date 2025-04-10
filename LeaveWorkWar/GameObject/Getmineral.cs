namespace LeaveWorkWar;
using LeaveWorkWar.Items;

public class Getmineral : GameObject
{
    private Random random;
    private Item item;
    public Getmineral(char symbol, Vector2 position) : base(ConsoleColor.DarkGray, symbol, position, false)
    {
        random = new Random();
    }

    public override void Interact(Player player)
    {
        int value= random.Next(0,100);
        Thread.Sleep(1000);

        if (value < 25)
        {
            player.Inventory.Add(new Stone());
        }
        else if (value < 45)
        {
            player.Inventory.Add(new Copper());
        }
        else if (value < 65)
        {
            player.Inventory.Add(new Iron());
        }
        else if (value < 85)
        {
            player.Inventory.Add(new Gold());
        }
        else if (value < 95)
        {
            player.Inventory.Add(new Diamond());
        }
        else
        {
            player.Inventory.Add(new Emerald());
        }
    }
}