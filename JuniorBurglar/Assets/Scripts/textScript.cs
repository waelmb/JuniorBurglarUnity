﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class textScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.D)) {
            Debug.Log("pressingKey");
            Destroy(gameObject, 0.5F);
        }
    }
}
