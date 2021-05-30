using UnityEngine;
using System;

[Serializable]
public class mob
{
    public string ID;
    public int HP;
    public int MagicRes;
    public int Damage;
}

[Serializable]
public class mobs
{
    public mob[] Mobs;
}
