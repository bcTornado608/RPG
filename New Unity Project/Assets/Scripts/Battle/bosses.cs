using System;
using UnityEngine;

[Serializable]
public class boss
{
    public string ID;
    public int HP;
    public int PhysicalRes;
    public int MagicalRes;
    public int Damage;
    public int Target;
    public string Ult1Name;
    public int Ult1Damage;
    public int Ult1Target;
    public int Ult1Status;
    public int Ult1Buff;
}

[Serializable]
public class bosses
{
    public boss[] Bosses;
}
