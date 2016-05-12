using UnityEngine;
using System.Collections;

public class BaseWeapon : BaseItem //BaseWeapon < BaseItem
{
	private int weaponDamage;
	private float weaponAttackSpeed;
	private bool weaponIsTwoHanded;

	public enum WeaponDamageTypes
    {
        SLASH,
        PIERCE,
        BLUNT
    }
    private WeaponDamageTypes weaponDamageType;

	public enum WeaponTypes
	{
		MELEE,
		RANGED
	}
	private WeaponTypes weaponType;

    public int WeaponDamage
	{
		get{return weaponDamage;}
		set{weaponDamage = value;}
	}
    public float WeaponAttackSpeed
	{
		get{return weaponAttackSpeed;}
		set{weaponAttackSpeed = value;}
	}
    public bool WeaponIsTwoHanded
	{
		get{return weaponIsTwoHanded;}
		set{weaponIsTwoHanded = value;}
	}

    public WeaponDamageTypes WeaponDamageType
    {
        get{return weaponDamageType;}
        set{weaponDamageType = value; }
    }

    public WeaponTypes WeaponType
	{
		get{return weaponType;}
		set{weaponType = value;}
	}
}
