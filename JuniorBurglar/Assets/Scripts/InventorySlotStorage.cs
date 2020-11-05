using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventorySlotStorage : InventorySlot
{
    Storage storage;
    Inventory inventory;
    public GameObject storageUI;
    public GameObject inventoryUI;

    void Start()
    {
        storage = Storage.instance;
        inventory = Inventory.instance;
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
    }

    public new void onRemoveButton()
    {
        UnityEngine.Debug.Log("InventorySlotStorage: onRemoveButton: " + item.name);
        Storage.instance.Remove(item);
    }
}
