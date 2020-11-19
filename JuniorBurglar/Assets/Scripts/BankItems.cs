using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BankItems : MonoBehaviour
{
    // Start is called before the first frame update
    public int number;
    void Start()
    {
        if (ItemList.BankItemList[number]) {
            Destroy(gameObject);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
