using UnityEngine;
using System.Collections;

public class BaseDex : BaseStat
{
    public BaseDex()
    {
        StatName = "Dexterity";
        StatDescription = "Increases your attack speed and evasion chance";
        StatType = StatTypes.DEX;
        StatBaseValue = 5;
        StatModifiedValue = 0;
    }
}