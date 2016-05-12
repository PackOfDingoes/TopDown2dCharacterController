using UnityEngine;
using System.Collections;

public class BaseCha : BaseStat
{
    public BaseCha()
    {
        StatName = "Charisma";
        StatDescription = "Reduces the price of item at shops, increases sell price";
        StatType = StatTypes.CHA;
        StatBaseValue = 5;
        StatModifiedValue = 0;
    }
}