using UnityEngine;
using System.Collections;
using System.Collections.Generic;
namespace AssemblyCSharp.Assets.Scripts.Battle
{

    public class JSONReader : MonoBehaviour
    {
        public TextAsset jsonWeapons;
        public TextAsset jsonMobs;
        public TextAsset jsonBosses;
        public TextAsset jsonArmors;

        private static SortedDictionary<string, weapon> weaponDict = new SortedDictionary<string, weapon>();
        private static SortedDictionary<string, mob> mobDict = new SortedDictionary<string, mob>();
        private static SortedDictionary<string, boss> bossDict = new SortedDictionary<string, boss>();
        private static SortedDictionary<string, armor> armorDict = new SortedDictionary<string, armor>();

        void Awake()
        {
            // get weapons info
            weapons weaponsInJson = JsonUtility.FromJson<weapons>(jsonWeapons.text);

            foreach (weapon a in weaponsInJson.Weapons)
            {
                weaponDict.Add(a.ID, a);
            }

            // get mobs info
            mobs mobsInJson = JsonUtility.FromJson<mobs>(jsonMobs.text);

            foreach (mob a in mobsInJson.Mobs)
            {
                mobDict.Add(a.ID, a);
            }

            // get bosses info
            bosses bossesInJson = JsonUtility.FromJson<bosses>(jsonBosses.text);

            foreach (boss a in bossesInJson.Bosses)
            {
                bossDict.Add(a.ID, a);
            }

            // get armors info
            armors armorsInJson = JsonUtility.FromJson<armors>(jsonArmors.text);

            foreach (armor a in armorsInJson.Armors)
            {
                armorDict.Add(a.ID, a);
            }
        }

        // define getItem method
        public static weapon getWeapon(string id)
        {
            return weaponDict[id].copy();
        }

        public static mob getMob(string id)
        {
            return mobDict[id].copy();
        }

        public static boss getBoss(string id)
        {
            return bossDict[id].copy();
        }

        public static armor getArmor(string id)
        {
            return armorDict[id].copy();
        }
    }
}