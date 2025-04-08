﻿namespace LeaveWorkWar;

public class MountainArt
{
    public ConsoleColor Color;
    public Vector2 position1;
    public Vector2 position2;
    

    public MountainArt(ConsoleColor Color, Vector2 Position1, Vector2 Position2)
    {
        this.Color = Color;
        this.position1 = Position1;
        this.position2 = Position2;
        
    }

    public void Draw()
    {
        Console.SetCursorPosition(position1.x, position1.y);
        Console.ForegroundColor = Color;
        Console.WriteLine(" /\\/\\");
        Console.SetCursorPosition(position2.x, position2.y);
        Console.WriteLine("/  M  \\");
        Console.ResetColor();
    }
}