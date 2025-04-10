namespace LeaveWorkWar;

public class Monster : GameObject
{
    public int CurHP { get; private set; }
    public int MaxHP { get; private set; }
    public int Damage { get; private set; }
    public bool IsAlive;
    private Random random;
    public Monster(char symbol, Vector2 position, int maxHp, int damage) : base(ConsoleColor.Red, symbol, position, true)
    {
        MaxHP = maxHp;
        CurHP = maxHp;
        Damage = damage;
        random = new Random();
    }

    public void TakeDamage(int damage)
    {
        CurHP -= damage;
        if (CurHP <= 0)
        {
            IsAlive = false;
        }
    }

    public void Update()
    {
        if (monster.Position.x == Game.Player.position1.x)
        {
            Game.Player.TakeDamage(monster.Damage);
        }
    }

    public void Move()
    {
        int direction = random.Next(-1,1);
        position.x += direction;
    }


    public override void Interact(Player player)
    {
        
    }
}