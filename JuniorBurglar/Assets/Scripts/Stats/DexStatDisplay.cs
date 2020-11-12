using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DexStatDisplay : PlayerStats
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
        getDexval();
        dexText.text = getDexval().ToString();
    }
}
