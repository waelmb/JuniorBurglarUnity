using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnSceneLoad : MonoBehaviour
{
    // Start is called before the first frame update
    void Awake()
    {
        UnityEngine.Debug.Log("OnSceneLoad, Awake()");
        //update inventory
        if(Inventory.instance != null)
        {
            Inventory.instance.SceneSwitched();

        }
    }
}
