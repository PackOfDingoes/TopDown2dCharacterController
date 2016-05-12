using UnityEngine;
using System.Collections;

public class BaseCon : BaseStat
{
    public BaseCon()
    {
        StatName = "Constitution";
        StatDescription = "Increases your maximum HP and damage mitigation";
        StatType = StatTypes.CON;
        StatBaseValue = 5;
        StatModifiedValue = 0;
    }
}