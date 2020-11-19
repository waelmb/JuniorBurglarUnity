using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RetirementHomeItems : MonoBehaviour
{
    public int number;
    // Start is called before the first frame update
    void Start()
    {
        if (ItemList.RetirementHomeItemList[number]) {
            Destroy(gameObject);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

}
