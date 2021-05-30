using System.IO;
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

        // Item wrongitem = new Item("no_item_named_this");
        Item item1 = new Item("test_item");
        Item item2 = new Item("test_item");

        item2.setTag("tag1", "helloworld");
        item.setTag("tag1a", "helloworld");
        item1.setTag("tag1a", "helloworld");
        item2.setTag("tag123", "helloworld");

        print(item1.isSameItem(item2));
        print(item1.stackableWith(item2));
        print(item1.stackableWith(item));
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void writeFile(){
        FileStream file = File.Create(Application.persistentDataPath + "/gamesave.save");
        StreamWriter writer = new StreamWriter(file, System.Text.Encoding.UTF8);
        writer.Write("Helloworld");
        file.Close();
    }
}
