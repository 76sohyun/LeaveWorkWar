﻿namespace LeaveWorkWar.Items;

public class Gold : Item
{
    public Gold()
    {
        name = "금";
        price = 1000;
        description = "금은 노란색이다...";
        symbol = "●";
        amount = 1;
    }

    public override void Use()
    {
        
    }
}