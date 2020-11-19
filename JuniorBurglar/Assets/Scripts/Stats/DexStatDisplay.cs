using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DexStatDisplay : CharacterStats
{
    Text dexText;


    // Start is called before the first frame update
    void Start()
    {
        dexText = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        float temp = getDexValue();
        UnityEngine.Debug.Log("this is the dex value: " + temp);
        dexText.text = temp.ToString();
    }
}
