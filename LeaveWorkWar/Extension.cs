namespace LeaveWorkWar;

public class Extension
{
    
}

public static class Util
{
    public static void PressAnyKey(string text)
    {
        Console.WriteLine(text);
        Console.WriteLine("계속 하려면 아무키나 누르세요...");
        Console.ReadKey();
    }

    public static void Print(string context, ConsoleColor textColor, int delay)
    {
        Console.ForegroundColor = textColor;
        Console.WriteLine(context);
        Thread.Sleep(delay);
        Console.ResetColor();
    }
}