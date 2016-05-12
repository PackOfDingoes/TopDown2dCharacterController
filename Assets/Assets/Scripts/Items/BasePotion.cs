using UnityEngine;
using System.Collections;

public class BasePotion : BaseItem
{
    private int potionHPRestored;
    private int potionMPRestored;
    private bool potionRevivesDead;
    private bool potionCuresStatus;

    public enum PotionTypes
    {
        HP,
        MP,
        REVIVE,
        UTILITY
    }

    private PotionTypes potionType;

    public PotionTypes PotionType
    {
        get { return potionType;}
        set { potionType = value;}
    }

    public int PotionHPRestored
    {
        get { return potionHPRestored; }
        set { potionHPRestored = value; }
    }
    public int PotionMPRestored
    {
        get { return potionMPRestored; }
        set { potionMPRestored = value; }
    }
    public bool PotionRevivesDead
    {
        get { return potionRevivesDead; }
        set { potionRevivesDead = value; }
    }
    public bool PotionCuresStatus
    {
        get { return potionCuresStatus; }
        set { potionCuresStatus = value; }
    }
}
