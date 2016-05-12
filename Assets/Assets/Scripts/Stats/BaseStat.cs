using UnityEngine;
using System.Collections;

public class BaseStat
{
    private string statName;
    private string statDescription;
    private int statBaseValue;
    private int statModifiedValue;

    public enum StatTypes
    {
        STR,
        DEX,
        CON,
        INT,
        WIS,
        CHA
    }

    private StatTypes statTypes;

    public StatTypes StatType
    {
        get { return statTypes;}
        set { statTypes = value;}
    }

    public string StatName
    {
        get { return statName; }
        set { statName = value; }
    }
    public string StatDescription
    {
        get { return statDescription; }
        set { statDescription = value; }
    }
    public int StatBaseValue
    {
        get { return statBaseValue; }
        set { statBaseValue = value; }
    }
    public int StatModifiedValue
    {
        get { return statModifiedValue; }
        set { statModifiedValue = value; }
    }
}
