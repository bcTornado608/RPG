using System.Collections.Generic;
using System.IO;
using UnityEngine;

[System.Serializable]
public class Inventory
{
    public static int ITEM_CAPACITY = 30;
    public static int ARMOR_CAPACITY = 4;
    public static int DECORATION_CAPACITY = 4;

    public List<Item> items;
    public List<Item> armors;
    public List<Item> decorations;
    public Item weapon;

    public static Inventory fromJson(string jsonStr)
    {
        Inventory inv = JsonUtility.FromJson<Inventory>(jsonStr);
        return inv;
    }

    public string toJson()
    {
        string jsonStr = JsonUtility.ToJson(this);
        return jsonStr;
    }

    public Inventory()
    {
        items = new List<Item>();
        armors = new List<Item>();
        decorations = new List<Item>();
        weapon = null;
    }

    public bool canAddItem(Item item)
    {
        if (items.Count < ITEM_CAPACITY)
        {
            return true;
        }
        foreach (Item existing in this.items)
        {
            if (item.stackableWith(existing))
            {
                return true;
            }
        }
        return false;
    }

    /// return true if seccessed, false if pack is full
    public bool addItem(Item item)
    {
        if (this.canAddItem(item))
        {
            // find stackable item
            Item stackable = null;
            foreach (Item existing in this.items)
            {
                if (item.stackableWith(existing))
                {
                    stackable = existing;
                    break;
                }
            }
            // add
            if (stackable == null)
            {
                //no stackable
                items.Add(item);
                return true;
            }
            else
            {
                // stackable
                stackable.Count += item.Count;
                return true;
            }
        }
        else
        {
            return false;
        }
    }

    // retrun a list of items with the same ID
    public List<Item> findItems(Item item)
    {
        List<Item> founds = new List<Item>();
        foreach (Item existing in this.items)
        {
            if (item.isSameItem(existing))
            {
                founds.Add(existing);
            }
        }
        return founds;
    }

    // return true if there is more/equal amount of item in the inventory
    public bool hasItem(Item item)
    {
        List<Item> founds = this.findItems(item);

        int count = 0;
        foreach (Item existing in founds)
        {
            count += existing.Count;
        }
        return count >= item.Count;
    }

    // return true if succeed
    public bool removeItem(Item item)
    {
        if (!this.hasItem(item))
        {
            return false;
        }
        else
        {
            // pop item
            int targetCount = item.Count;
            for (int i = this.items.Count - 1; i >= 0; i++)
            {
                Item existing = this.items[i];
                if (item.isSameItem(existing))
                {
                    // pop
                    if (existing.Count < targetCount)
                    {
                        // one stack is not enough, pop and find more
                        targetCount -= existing.Count;
                        this.items.Remove(existing);
                        continue;
                    }
                    else
                    {
                        // one stack is enough
                        existing.Count -= item.Count;
                        if (existing.Count <= 0)
                        {
                            items.Remove(existing);
                        }
                        return true;
                    }
                }
            }
            // there is no enough item. This should not happen
            return false;
        }
    }
}
