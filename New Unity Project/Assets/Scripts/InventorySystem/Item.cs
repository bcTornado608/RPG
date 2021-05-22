using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// The base class for Items
public abstract class Item
{
    string itemId;
    int count;

    Dictionary<string, string> stringTags;
    Dictionary<string, int> intTags;
    Dictionary<string, float> floatTags;


}
