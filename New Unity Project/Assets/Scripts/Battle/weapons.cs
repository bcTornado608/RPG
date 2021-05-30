using UnityEngine;
using System;

[Serializable]
public class weapon
{
    public string ID;
    public string Type;
    public string Name;
    public int Damage;
    public int DamageType;
    public int SA;
    public string UltName;
    public double UltDamage;
    public int UltDamageType;
    public int UltMPCost;
    public int UltStatus;
    public double UltRecovery;
    public int UltBuff;
}

[Serializable]
public class weapons
{
    public weapon[] Weapons;
}