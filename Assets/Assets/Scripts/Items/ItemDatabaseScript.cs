using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System.Xml;
using System.IO;

public class ItemDatabaseScript : MonoBehaviour
{
    public TextAsset itemInventory;
    public static List<BaseItem> inventoryItems = new List<BaseItem>();

    private List<Dictionary<string, string>> inventoryItemsDictionary = new List<Dictionary<string, string>>();
    private Dictionary<string, string> inventoryDictionary;

    void Awake()
    {
        ReadItemsFromDatabase();
        for(int i = 0; i < inventoryItemsDictionary.Count; i++)
        {
            inventoryItems.Add(new BaseItem(inventoryItemsDictionary[i]));
        }
    }

    public void ReadItemsFromDatabase()
    {
        XmlDocument xmlDocument = new XmlDocument();
        xmlDocument.LoadXml(itemInventory.text);
        XmlNodeList itemList = xmlDocument.GetElementsByTagName("Item");

        foreach(XmlNode itemInfo in itemList)
        {
            XmlNodeList itemContent = itemInfo.ChildNodes;
            inventoryDictionary = new Dictionary<string, string>(); //ItemName: TestItem

            foreach(XmlNode content in itemContent)
            {
                switch(content.Name)
                {
                    case "ID":
                        inventoryDictionary.Add("ID", content.InnerText);
                        break;
                    case "Name":
                        inventoryDictionary.Add("Name", content.InnerText);
                        break;
                    case "Type":
                        inventoryDictionary.Add("Type", content.InnerText);
                        break;
                }
            }

            inventoryItemsDictionary.Add(inventoryDictionary);
        }
    }
}
