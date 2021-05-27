using System.Reflection;

/// item info class used to store json data in memory
/// properties includes: name, type, rarity, description, story, icon
/// item data in the json file should have same structure
[System.Serializable]
public class ItemInfo{
    public string id;
    public string name;
    public string category;
    public string rarity;
    public string description;
    public string story;
    public string icon;

    public string getTag(string tag)
    {
        System.Type thisType = this.GetType();
        FieldInfo field = thisType.GetField(tag);
        if(field == null){
            return null;
        }
        if (field.FieldType == typeof(string))
        {
            return field.GetValue(this) as string;
        }
        return null;
    }
    public ItemInfo copy()
    {
        return this.MemberwiseClone() as ItemInfo;
    }

    public override string ToString()
    {
        return base.ToString() + ":" + this.id;
    }
}