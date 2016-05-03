using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;

public class ItemsIndex : IEquatable<ItemsIndex>
{
	public int IDItem{get; set;}
	public string nameItem{get; set;}

	public override string ToString()
	{
		return "Item ID: " + IDItem + "\n Name: " + nameItem;
	}

	public override bool Equals(object obj)
	{
		if (obj == null) return false;
		ItemsIndex objAsItems = obj as ItemsIndex;
		if (objAsItems == null) return false;
		else return Equals(objAsItems);
	}

	public override int GetHashCode()
	{
		return IDItem;
	}

	public bool Equals(ItemsIndex other)
	{
		if (other == null) return false;
		return(this.IDItem.Equals(other.IDItem));
	}
}

public class Items : MonoBehaviour 
{
	public List<ItemsIndex> items = new List<ItemsIndex>();

	void Start () 
	{
		
	}

	void Update () 
	{
	
	}
}
