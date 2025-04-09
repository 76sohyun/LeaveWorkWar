namespace LeaveWorkWar;

public abstract class Item
{
    public string symbol;
    public string name;
    public string description;

    public Item(string symbol, string name, string description)
    {
        this.symbol = symbol;
        this.name = name;
        this.description = description;
    }
    
    public abstract void Use();
}