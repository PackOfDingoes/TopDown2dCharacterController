using UnityEngine;
using System.Collections;

public class BaseWis : BaseStat
{
    public BaseWis()
    {
        StatName = "Wisdom";
        StatDescription = "Greatly increases the size of your mana pool, increases spell healing";
        StatType = StatTypes.WIS;
        StatBaseValue = 5;
        StatModifiedValue = 0;
    }
}