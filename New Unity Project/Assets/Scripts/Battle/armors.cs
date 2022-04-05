using System;
using UnityEngine;

namespace AssemblyCSharp.Assets.Scripts.Battle
{
    [Serializable]
    public class armor
    {
        public string ID;
        public string Name;
        public string Type;
        public int HP;
        public int MP;
        public int SA;

        public armor copy()
        {
            return this.MemberwiseClone() as armor;
        }
    }

    [Serializable]
    public class armors
    {
        public armor[] Armors;
    }
}
