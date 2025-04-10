namespace LeaveWorkWar;

public class Target : GameObject
{
    public Vector2 position;
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

    public void Collision(Target target)
    {
        if (target == null) return;
        if (position.x == target.position.x && position.y == target.position.y)
        {
            Game.Player.Money += target.Reward;
        }
    }
}