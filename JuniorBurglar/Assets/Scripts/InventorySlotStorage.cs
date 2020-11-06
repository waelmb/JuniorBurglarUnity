using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InventorySlotStorage : InventorySlot
{
    Storage storage;
    Inventory inventory;
    public GameObject storageUI;
    public GameObject inventoryUI;
    public Text text;

    void Start()
    {
        storage = Storage.instance;
        inventory = Inventory.instance;
        text.enabled = false;
    }

    public new void UseItem()
    {
        UnityEngine.Debug.Log("InventorySlotStorage: UseItem: " + item.name);

        //if both are active, move items from storage to inventory 
        if (storageUI.activeSelf && inventoryUI.activeSelf)
        {
            if (inventory.Add(item))
            {
                UnityEngine.Debug.Log("Added to inventory: " + item.name);
                storage.Remove(item);
            }
        }
        else if (storageUI.activeSelf) {
            if (item.GetType() == typeof(NPCs)) {
                Debug.Log("Sold NPC");
                CoinUpdate.coinAmount += (int) item.str.GetValue();
                text.text = "NPC sold, you were given " + (int) item.str.GetValue() + " coins in return!";
                text.enabled = true;
                storage.Remove(item);
                StartCoroutine(LoadLevelAfterDelay(2F));
            }
        }
    }

    public new void onRemoveButton()
    {
        UnityEngine.Debug.Log("InventorySlotStorage: onRemoveButton: " + item.name);
        Storage.instance.Remove(item);
    }

    IEnumerator LoadLevelAfterDelay(float delay)
    {
        Debug.Log("Got to disable text");
        yield return new WaitForSeconds(delay);
        text.enabled = false;
    }

}
