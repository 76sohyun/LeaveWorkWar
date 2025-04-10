namespace LeaveWorkWar;

public class PStore : GameObject
{
    public PStore(char symbol, Vector2 position) : base(ConsoleColor.DarkCyan, symbol, position, false)
    {
        
    }

    public override void Interact(Player player)
    {
        player.pickStore.Open(player);
    }
}