namespace LeaveWorkWar;

public class MountainGetCoin : GetCoin
{
    public MountainGetCoin(Vector2 position) : base('C', position)
    {
        name = "티끌모아코인";
        money = 2;
    }
}