using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace AssemblyCSharp.Assets.Scripts.Battle
{
    public class TestScript : MonoBehaviour
    {
        // Start is called before the first frame update
        void Start()
        {
            Debug.Log(JSONReader.getWeapon("safdsdf").Name);
        }

        // Update is called once per frame
        void Update()
        {

        }
    }
}