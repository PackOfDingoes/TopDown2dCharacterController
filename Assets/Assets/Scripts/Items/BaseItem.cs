using UnityEngine;
using System.Collections;
using System.Collections.Generic;


public class BaseItem
{
    public BaseItem() {}
//	ALL ITEMS
	private int itemID;
	private string itemName;
	private string itemDescription;
	private int itemGoldValue;
//	private Dictionary<string, int> itemRequirements = new Dictionary<string, int>();
	private int itemLvlRequirement;
//	REQUIREMENTS
	public enum ItemTypes
	{
		WEAPON,
		ARMOUR,
		POTION
	}
	private ItemTypes itemType;

    public BaseItem (Dictionary<string,string> itemsDictionary)
    {
        itemID = int.Parse(itemsDictionary["ItemID"]);
        itemName = itemsDictionary["ItemName"];
        itemDescription = itemsDictionary["ItemDescription"];
        itemID = int.Parse(itemsDictionary["ItemID"]);
        itemGoldValue = int.Parse(itemsDictionary["ItemGoldValue"]);
        itemLvlRequirement = int.Parse(itemsDictionary["ItemLvlReq"]);
        itemID = int.Parse(itemsDictionary["ItemID"]);
        itemType = (ItemTypes)System.Enum.Parse(typeof(BaseItem.ItemTypes), itemsDictionary["ItemType"].ToString());
    }

//	START GET AND SETS
	public int ItemID
	{
		get{return itemID;}
		set{itemID = value;}
	}
	public string ItemName
	{
		get{return itemName;}
		set{itemName = value;}
	}
	public string ItemDescription
	{
		get{return itemDescription;}
		set{itemDescription = value;}
	}
	public int ItemGoldValue
	{
		get{return itemGoldValue;}
		set{itemGoldValue = value;}
	}
//	ITEM REQUIREMENTS
	public int ItemLvlRequirement
	{
		get{return itemLvlRequirement;}
		set{itemLvlRequirement = value;}
	}
//	ITEM TYPES
	public ItemTypes ItemType
	{
		get{return itemType;}
		set{itemType = value;}
	}
}

