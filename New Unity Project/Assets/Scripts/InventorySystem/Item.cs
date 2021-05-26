using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// The base class for Items
[System.Serializable]
public class Item
{
    string itemId;
    int count;

    Dictionary<string, string> stringTags;

}
