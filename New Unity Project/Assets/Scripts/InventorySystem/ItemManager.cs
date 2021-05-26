using System.Collections.Generic;
using UnityEngine;

public class ItemManager
{
    public static ItemManager Instance { get; private set; }

    private ItemInfoCollection itemInfoCollection;

    private ItemManager()
    {
        // read string
        string jsonStr = "";
        // ...

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