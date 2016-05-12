using UnityEngine;
using System.Collections;

public class BaseMeleeWeapon : BaseWeapon //BaseMeleeWeapon < BaseWeapon < BaseItem 
{
	private bool meleeWeaponHasReach;
	private bool meleeWeaponIsHeavy;

	public enum MeleeWeaponTypes
	{
		SWORD,
		AXE,
		MACE,
		SPEAR,
		DAGGER,
		STAFF,
		WAND
	}
	private MeleeWeaponTypes meleeWeaponType;

    public bool MeleeWeaponHasReach
	{
		get{return meleeWeaponHasReach;}
		set{meleeWeaponHasReach = value;}
	}
    public bool MeleeWeaponIsHeavy
	{
		get{return meleeWeaponIsHeavy;}
		set{meleeWeaponIsHeavy = value;}
	}
    public MeleeWeaponTypes MeleeWeaponType
	{
		get{return meleeWeaponType;}
		set{meleeWeaponType = value;}
	}
}
