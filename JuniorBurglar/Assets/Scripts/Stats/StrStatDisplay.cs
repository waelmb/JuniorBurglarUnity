using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class StrStatDisplay : PlayerStats
{
    Text strText;
    // Start is called before the first frame update
    void Start()
    {
        strText = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        UnityEngine.Debug.Log("this is the str value: " + getStrval());
        strText.text = getStrval().ToString();   
    }
}
