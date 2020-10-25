using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CallPolice : MonoBehaviour
{
    
    bool call = false;
    GameObject nurse;
    GameObject player;
    GameObject phone;
    float step;

    // Start is called before the first frame update
    void Start()
    {
        nurse = GameObject.FindWithTag("Nurse");
        player = GameObject.FindWithTag("Player");
        phone = GameObject.FindWithTag("Phone");
    }

    // Update is called once per frame
    void Update()
    {
        
        if (Vector3.Distance (nurse.transform.position, player.transform.position) <= 2) {
            call = true;
        }
        if (call == true) {
            Debug.Log("call = true");
            
            nurse.transform.position = Vector2.MoveTowards(nurse.transform.position, phone.transform.position, 0.001F);
        }
    }
}
