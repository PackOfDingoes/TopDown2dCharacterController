using UnityEngine;
using System.Collections;

public class BaseWeapon : BaseItem //BaseWeapon < BaseItem
{
	private int weaponDamage;
	private float weaponAttackSpeed;
	private bool weaponIsTwoHanded;
	private string weaponDamageType;

	public enum WeaponTypes
	{
		MELEE,
		RANGED
	}
	private WeaponTypes weaponType;

	private int WeaponDamage
	{
		get{return weaponDamage;}
		set{weaponDamage = value;}
	}
	private float WeaponAttackSpeed
	{
		get{return weaponAttackSpeed;}
		set{weaponAttackSpeed = value;}
	}
	private bool WeaponIsTwoHanded
	{
		get{return weaponIsTwoHanded;}
		set{weaponIsTwoHanded = value;}
	}
	private string WeaponDamageType
	{
		get{return weaponDamageType;}
		set{weaponDamageType = value;}
	}

	private WeaponTypes WeaponType
	{
		get{return weaponType;}
		set{weaponType = value;}
	}
}
