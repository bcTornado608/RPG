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
        TextAsset txt = Resources.Load<TextAsset>("Items/sampleJson.json");
        jsonStr = txt.ToString();

        // create json objects
        this.itemInfoCollection = JsonUtility.FromJson<ItemInfoCollection>(jsonStr);
        
    }

    public static void Init()
    {
        if(ItemManager.Instance == null){
            ItemManager.Instance = new ItemManager();
        }
    }
}