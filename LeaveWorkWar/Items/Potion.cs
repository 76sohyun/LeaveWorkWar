namespace LeaveWorkWar.Items;

public class Potion : Item
{
    public Potion()
    {
        name = "회복포션";
        price = 10000;
        description = "체력을 2만큼 회복시켜준다.";
        Console.ForegroundColor = ConsoleColor.Red;
        symbol = "♥";
        Console.ResetColor();
    }

    public override void Use()
    {
        Game.Player.Heal(2);
    }
}