﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaygroundItems : MonoBehaviour
{
    // Start is called before the first frame update
    public int number;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (ItemList.PlaygroundItemList[number]) {
            Destroy(gameObject);
        }
    }
}
