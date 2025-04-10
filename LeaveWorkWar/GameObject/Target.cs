namespace LeaveWorkWar;

public class Target : GameObject
{
    public int Reward;
    public bool IsActive;
    public Target(Vector2 position, int reward) : base(ConsoleColor.Yellow, '◎', position, false)
    {
        Reward = reward;
        IsActive = true;
    }

    public void Attack()
    {
        Game.Player.Money += Reward;
    }

    public override void Interact(Player player)
    {
        if (IsActive)
        {
            Attack();
        }
    }
}