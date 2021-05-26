using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestScript : MonoBehaviour
{
    public ItemManager itemManager;

    // Start is called before the first frame update
    void Start()
    {
        ItemManager.Init();
        itemManager = ItemManager.Instance;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
