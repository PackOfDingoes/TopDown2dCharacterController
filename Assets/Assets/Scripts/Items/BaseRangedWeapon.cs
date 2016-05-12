using UnityEngine;
using System.Collections;

public class BaseRangedWeapon : BaseWeapon //BaseRangedWeapon < BaseWeapon < BaseItem 
{
    public enum AmmoTypes
    {
        ARROW,
        BOLT
    }
    private AmmoTypes ammoTypes;

    public enum RangedWeaponTypes
    {
        BOW,
        CROSSBOW
    }
    private RangedWeaponTypes rangedWeaponTypes;

    public AmmoTypes AmmoType
    {
        get { return ammoTypes; }
        set { ammoTypes = value; }
    }
    public RangedWeaponTypes RangedWeaponType
    {
        get { return rangedWeaponTypes; }
        set { rangedWeaponTypes = value; }
    }

}
