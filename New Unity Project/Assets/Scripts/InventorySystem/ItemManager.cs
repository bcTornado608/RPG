using System.Collections.Generic;
using UnityEngine;

/// the global manager for item id and data
public class ItemManager
{
    public static ItemManager Instance { get; private set; }

    private Dictionary<string, ItemInfo> itemDictionary;

    private ItemManager()
    {
        // read string
        string jsonStr = "";
        TextAsset txt = Resources.Load<TextAsset>("Items/sampleJson");
        jsonStr = txt.ToString();

        // create json object
        ItemInfoCollection itemInfoCollection;
        itemInfoCollection = JsonUtility.FromJson<ItemInfoCollection>(jsonStr);

        // build lookup table
        itemDictionary = new Dictionary<string, ItemInfo>();
        foreach(ItemInfo info in itemInfoCollection.itemInfos)
        {
            itemDictionary.Add(info.id, info);
        }

        // test
        foreach(ItemInfo info in itemDictionary.Values)
        {
            Debug.Log(info.name);
        }
    }

    public static void Init()
    {
        if(ItemManager.Instance == null){
            ItemManager.Instance = new ItemManager();
        }
    }
}