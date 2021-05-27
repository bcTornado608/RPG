using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestScript : MonoBehaviour
{
    public ItemManager itemManager;

    // Start is called before the first frame update
    void Start()
    {
        ItemManager.Init();
        itemManager = ItemManager.Instance;

        ItemInfo info = itemManager.getItemInfo("test_item");
        print(info);

        print(info.getTag("name"));

        Item item = new Item("test_item");
        print(item.getID());
        print(item.getName());
        print(item.getCategory());
        print(item.getRarity());
        print(item.getDescription());
        print(item.getStory());
        print(item.getIcon());
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
