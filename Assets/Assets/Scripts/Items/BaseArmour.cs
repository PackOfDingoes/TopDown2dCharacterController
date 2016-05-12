using UnityEngine;
using System.Collections;

public class BaseArmour : BaseItem  //BaseArmour < BaseItem
{
	private int armourDefense;

	public enum ArmourTypes
	{
		HELMET,
		CHEST,
		GLOVES,
		PANTS,
		BOOTS
	}

    private ArmourTypes armourTypes;

    public int ArmourDefense
    {
        get { return armourDefense; }
        set { armourDefense = value; }
    }
    public ArmourTypes ArmourType
    {
        get { return armourTypes; }
        set { armourTypes = value; }
    }
}
