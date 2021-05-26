using System.Collections.Generic;
using UnityEngine;

/// the global manager for item id and data
public class ItemManager
{
    public static ItemManager Instance { get; private set; }

    private ItemInfoCollection itemInfoCollection;

    private ItemManager()
    {
        // read string
        string jsonStr = "";
        TextAsset txt = Resources.Load<TextAsset>("Items/sampleJson");

        jsonStr = txt.ToString();

        // create json objects
        this.itemInfoCollection = JsonUtility.FromJson<ItemInfoCollection>(jsonStr);

        // test
        foreach(ItemInfo info in this.itemInfoCollection.itemInfos)
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