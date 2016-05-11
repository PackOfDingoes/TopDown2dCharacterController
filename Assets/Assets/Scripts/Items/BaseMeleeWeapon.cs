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
		POLEARM,
		DAGGER,
		STAFF,
		WAND
	}
	private MeleeWeaponTypes meleeWeaponType;

	private bool MeleeWeaponHasReach
	{
		get{return meleeWeaponHasReach;}
		set{meleeWeaponHasReach = value;}
	}
	private bool MeleeWeaponIsHeavy
	{
		get{return meleeWeaponIsHeavy;}
		set{meleeWeaponIsHeavy = value;}
	}
	private MeleeWeaponTypes MeleeWeaponType
	{
		get{return meleeWeaponType;}
		set{meleeWeaponType = value;}
	}
}
