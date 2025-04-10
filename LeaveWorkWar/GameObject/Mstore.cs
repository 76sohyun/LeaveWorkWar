namespace LeaveWorkWar;

public class Mstore : GameObject
{
    public Mstore(char symbol, Vector2 position) : base(ConsoleColor.DarkCyan, symbol, position, false)
    {
        
    }

    public override void Interact(Player player)
    {
        player.mineStore.Open(player);
    }
}