using UnityEngine;
using System.Collections;

public class BaseArmour : BaseItem  //BaseArmour < BaseItem
{
	private int armourDefense;
	private int armourBonusHealth;

	public enum ArmourTypes
	{
		HELMET,
		CHEST,
		GLOVES,
		PANTS,
		BOOTS
	}
}
