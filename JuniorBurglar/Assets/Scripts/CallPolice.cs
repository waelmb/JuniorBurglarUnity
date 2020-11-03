using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CallPolice : MonoBehaviour
{
    
    bool call = false;
    bool pastDoor = false;
    GameObject nurse;
    GameObject player;
    GameObject phone;
    GameObject door;
    float step;
    public int radius = 2;
    public float speed = 0.001f;


    // Start is called before the first frame update
    void Start()
    {
        nurse = GameObject.FindWithTag("Nurse");
        player = GameObject.FindWithTag("Player");
        phone = GameObject.FindWithTag("Phone");
        door = GameObject.FindWithTag("Door");
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(Vector3.Distance(nurse.transform.position, phone.transform.position));
        if (Vector3.Distance(nurse.transform.position, player.transform.position) <= radius && pastDoor == false) {
            call = true;
        }

        if (call == true) {
            nurse.transform.position = Vector2.MoveTowards(nurse.transform.position, door.transform.position, speed);
            if (Vector3.Distance(nurse.transform.position, door.transform.position) <= 0.5) {
                call = false;
                pastDoor = true;
            }
        }

        if (pastDoor == true) {
            nurse.transform.position = Vector2.MoveTowards(nurse.transform.position, phone.transform.position, speed);
        }

        if (Vector3.Distance(nurse.transform.position, phone.transform.position) <= 0.1) {
            Debug.Log("here");
            SceneManager.LoadScene("Tutorialville");
            CoinUpdate.coinAmount -= 5;
        }
    }
}
