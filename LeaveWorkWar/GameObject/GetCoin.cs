namespace LeaveWorkWar;

public abstract class GetCoin : GameObject
{
    public string name;
    public int money;

    public GetCoin(char symbol, Vector2 position) : base(ConsoleColor.Magenta, symbol, position, false)
    {
        
    }

    public override void Interact(Player player)
    {
        
    }
}