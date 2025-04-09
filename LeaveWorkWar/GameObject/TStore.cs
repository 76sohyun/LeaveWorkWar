namespace LeaveWorkWar;

public class TStore : GameObject
{
    public TStore(char symbol, Vector2 position) : base(ConsoleColor.DarkCyan, symbol, position, false)
    {
        
    }

    public override void Interact(Player player)
    {
        player.townStore.Open(player);
    }
    
}