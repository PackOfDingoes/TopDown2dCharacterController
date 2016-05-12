﻿using UnityEngine;
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
	private int itemStrRequirement;
//	BONUS STATS PROVIDED
	private int itemBonusStr;
	private int itemBonusDex;
	private int itemBonusCon;
	private int itemBonusInt;
	private int itemBonusWis;
	private int itemBonusCha;
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
        itemStrRequirement = int.Parse(itemsDictionary["ItemStrReq"]);
        itemBonusStr = int.Parse(itemsDictionary["ItemBonusStr"]);
        itemBonusStr = int.Parse(itemsDictionary["ItemBonusDex"]);
        itemBonusStr = int.Parse(itemsDictionary["ItemBonusCon"]);
        itemBonusStr = int.Parse(itemsDictionary["ItemBonusInt"]);
        itemBonusStr = int.Parse(itemsDictionary["ItemBonusWis"]);
        itemBonusStr = int.Parse(itemsDictionary["ItemBonusCha"]);
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
	public int ItemStrRequirement
	{
		get{return itemStrRequirement;}
		set{itemStrRequirement = value;}
	}
//	BONUS STATS
	public int ItemBonusStr
	{
		get{return itemBonusStr;}
		set{itemBonusStr = value;}
	}
	public int ItemBonusDex
	{
		get{return itemBonusDex;}
		set{itemBonusDex = value;}
	}
	public int ItemBonusCon
	{
		get{return itemBonusCon;}
		set{itemBonusCon = value;}
	}
	public int ItemBonusInt
	{
		get{return itemBonusInt;}
		set{itemBonusInt = value;}
	}
	public int ItemBonusWis
	{
		get{return itemBonusWis;}
		set{itemBonusWis = value;}
	}
	public int ItemBonusCha
	{
		get{return itemBonusCha;}
		set{itemBonusCha = value;}
	}
//	ITEM TYPES
	public ItemTypes ItemType
	{
		get{return itemType;}
		set{itemType = value;}
	}
}

