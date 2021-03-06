using System.Collections.Generic;
using UnityEngine;

/// the global manager for item id and data
public class ItemManager
{
    public static ItemManager Instance { get; private set; }

    private SortedDictionary<string, ItemInfo> itemDictionary;

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
        itemDictionary = new SortedDictionary<string, ItemInfo>();
        foreach(ItemInfo info in itemInfoCollection.itemInfos)
        {
            itemDictionary.Add(info.id, info);
        }
    }

    public ItemInfo getItemInfo(string id)
    {
        if(this.itemDictionary.ContainsKey(id))
        {
            return this.itemDictionary[id].copy();
        }
        return null;
    }

    public static void Init()
    {
        if(ItemManager.Instance == null){
            ItemManager.Instance = new ItemManager();
        }
    }
}