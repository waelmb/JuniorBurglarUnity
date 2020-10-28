using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PickupBoot : MonoBehaviour
{
    [SerializeField]
    private bool pickUpallowed;
    private Text pickupText;

    // Start is called before the first frame update
    void Start()
    {
       // pickupText.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (pickUpallowed && Input.GetKeyDown(KeyCode.E))
            PickUp();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name.Equals("Player")) {
            pickupText.gameObject.SetActive(true);
            pickUpallowed = true;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.name.Equals("Player")) {
            pickupText.gameObject.SetActive(false);
            pickUpallowed = false;
        }
    }

    private void PickUp() {
        Destroy(gameObject);
    }
}
