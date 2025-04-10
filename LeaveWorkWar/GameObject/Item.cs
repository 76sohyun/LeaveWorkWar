namespace LeaveWorkWar;

public abstract class Item
{
    public string name;
    public string description;
    public int price;
    public int amount;
    public string symbol;
    
    

    public Item()
    {
        
    }
    
    public abstract void Use();
}