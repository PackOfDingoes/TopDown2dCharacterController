using UnityEngine;
using System.Collections;

public class BaseStr : BaseStat
{
    public BaseStr()
    {
        StatName = "Strength";
        StatDescription = "Allows you to wield heavier gear, increases melee damage";
        StatType = StatTypes.STR;
        StatBaseValue = 5;
        StatModifiedValue = 0;
    }
}