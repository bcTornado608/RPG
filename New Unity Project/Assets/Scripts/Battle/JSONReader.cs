using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class JSONReader : MonoBehaviour
{
    public TextAsset jsonWeapons;
    public TextAsset jsonMobs;
    public TextAsset jsonBosses;

    private SortedDictionary<string, weapon> weaponDic = new SortedDictionary<string, weapon>();
    private SortedDictionary<string, mob> mobDic = new SortedDictionary<string, mob>();
    private SortedDictionary<string, boss> bossDic = new SortedDictionary<string, boss>();

    void Start()
    {
        // get weapons info
        weapons weaponsInJson = JsonUtility.FromJson<weapons>(jsonWeapons.text);

        foreach (weapon a in weaponsInJson.Weapons)
        {
            weaponDic.Add(a.ID, a);
            Debug.Log(a.ID);
        }

        // get mobs info
        mobs mobsInJson = JsonUtility.FromJson<mobs>(jsonMobs.text);

        foreach (mob a in mobsInJson.Mobs)
        {
            mobDic.Add(a.ID, a);
            Debug.Log(a.ID);
        }

        // get bosses info
        bosses bossesInJson = JsonUtility.FromJson<bosses>(jsonBosses.text);

        foreach (boss a in bossesInJson.Bosses)
        {
            bossDic.Add(a.ID, a);
            Debug.Log(a.ID);
        }
    }
}
