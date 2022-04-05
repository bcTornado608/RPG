using UnityEngine;
using System;
namespace AssemblyCSharp.Assets.Scripts.Battle
{
    [Serializable]
    public class mob
    {
        public string ID;
        public int HP;
        public int MagicRes;
        public int Damage;

        public mob copy()
        {
            return this.MemberwiseClone() as mob;
        }
    }

    [Serializable]
    public class mobs
    {
        public mob[] Mobs;
    }
}