

/// item info class used to store json data in memory
/// properties includes: name, type, rarity, description, story, icon
/// item data in the json file should have same structure
[System.Serializable]
public class ItemInfo{
    public string id;
    public string name;
    public string type;
    public string rarity;
    public string description;
    public string story;
    public string icon;
}