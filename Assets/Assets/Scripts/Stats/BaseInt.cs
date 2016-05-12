using UnityEngine;
using System.Collections;

public class BaseInt : BaseStat
{
    public BaseInt()
    {
        StatName = "Intelligence";
        StatDescription = "Moderately increases your mana pool, increases spell damage";
        StatType = StatTypes.INT;
        StatBaseValue = 5;
        StatModifiedValue = 0;
    }
}