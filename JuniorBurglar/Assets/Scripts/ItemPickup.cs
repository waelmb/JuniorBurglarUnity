using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ItemPickup : MonoBehaviour
{
    private bool pickUpallowed;
    //private Text pickupText;
    public Item item;
    public int value=0;

    // Start is called before the first frame update
    void Start()
    {
        // pickupText.gameObject.SetActive(false);
        //pickupText.text = "pickupText";
    }

    // Update is called once per frame
    void Update()
    {
        if (pickUpallowed && Input.GetKeyDown(KeyCode.E)) {
            PickUp();
            //CoinUpdate.coinAmount += value;
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        //UnityEngine.Debug.Log("OnTriggerEnter2D: " + item.name);
        if (collision.gameObject.name.Equals("Player")) {
            //pickupText.gameObject.SetActive(true);
            pickUpallowed = true;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.name.Equals("Player")) {
            //pickupText.gameObject.SetActive(false);
            pickUpallowed = false;
        }
    }

    private void PickUp() {
        //Pickup Item
        UnityEngine.Debug.Log("picking up item: " + item.name);
        /*float strength = PlayerStats.Strength;
        //check if item is an NPC
        if (item.GetType() == typeof(NPCs) && item.str.GetValue() > CharacterStats.IncreaseStrength(strength))
        {
            //deduct coins
            UnityEngine.Debug.Log("NPC is stronger, can't kidnap ");
            CoinUpdate.coinAmount -= (int)item.str.GetValue();

            //kick out
            SceneManager.LoadScene("Tutorialville");
        }
        //attempt to add item
        else*/ if (Inventory.instance.Add(item))
        {
            Destroy(gameObject);
        }
        
    }
}
