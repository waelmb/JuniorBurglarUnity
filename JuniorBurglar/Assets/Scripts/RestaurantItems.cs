﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RestaurantItems : MonoBehaviour
{
    // Start is called before the first frame update
    public int number;
    void Start()
    {
        if (ItemList.RestaurantItemList[number]) {
            Destroy(gameObject);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}