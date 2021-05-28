using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// The base class for Items
[System.Serializable]
public class Item
{
    string id;

    int Count { get; set; }

    Dictionary<string, string> tags;

    public Item(string id, int count = 1)
    {
        this.id = id;

        if (ItemManager.Instance.getItemInfo(this.id) == null)
        {
            throw new InventoryDataException(string.Format("Unknown Item ID: {0}", this.id));
        }

        this.Count = count;
        this.tags = new Dictionary<string, string>();
    }

    public string getID()
    {
        return this.id;
    }

    public string getTag(string tag)
    {
        if (this.tags.ContainsKey(tag))
        {
            return this.tags[tag];
        }
        else
        {
            ItemManager manager = ItemManager.Instance;
            ItemInfo info = manager.getItemInfo(this.id);
            if (info == null)
            {
                return null;
            }
            string tag_value = info.getTag(tag);
            return tag_value;
        }
    }

    public void setTag(string key, string value)
    {
        if (value == null)
        {
            if (this.tags.ContainsKey(key))
            {
                this.tags.Remove(key);
            }
        }
        else if (this.tags.ContainsKey(key))
        {
            this.tags[key] = value;
        }
        else
        {
            this.tags.Add(key, value);
        }
    }

    public string getName()
    {
        return this.getTag("name");
    }
    public ItemCategory getCategory()
    {
        string categoryStr = this.getTag("category");
        if (categoryStr == null)
        {
            throw new InventoryDataException(
                string.Format("{0}: Item has no tag \"category\"",
                this.ToString()));
        }

        ItemCategory? category = (ItemCategory?)Enum.Parse(typeof(ItemCategory), categoryStr, true);
        if (category == null)
        {
            throw new InventoryDataException(string.Format(
                "{0}: Unknown item category \"{1}\"",
                this.ToString(), categoryStr));
        }
        return (ItemCategory)category;
    }
    public int getRarity()
    {
        string rarityStr = this.getTag("rarity");
        if (rarityStr == null)
        {
            throw new InventoryDataException(string.Format(
                "{0}: Item has no tag \"rarity\"", this.ToString()));
        }
        return int.Parse(rarityStr);
    }
    public string getDescription()
    {
        return this.getTag("description");
    }
    public string getStory()
    {
        return this.getTag("story");
    }
    public string getIcon()
    {
        return this.getTag("icon");
    }
}
