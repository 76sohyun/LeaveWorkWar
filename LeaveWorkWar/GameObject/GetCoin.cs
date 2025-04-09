namespace LeaveWorkWar;

public abstract class GetCoin : GameObject
{
    public string name;
    public int money;

    public GetCoin(char symbol, Vector2 position) : base(ConsoleColor.Magenta, symbol, position, false)
    {
        name = "티끌모아코인";
        money = 20;
    }

    public override void Interact(Player player)
    {
        player.Money += 20;
    }
}