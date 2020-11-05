using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventorySlotHome : InventorySlot
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
        UnityEngine.Debug.Log("InventorySlotHome: UseItem: " + item.name);

        //if both are active, move items from inventory to storage
        if(storageUI.activeSelf && inventoryUI.activeSelf)
        {
            if(storage.Add(item))
            {
                UnityEngine.Debug.Log("Added to storage: " + item.name);
                inventory.Remove(item);
            }
        }
        //if storage isn't active, equip item
        else if(!storageUI.activeSelf && inventoryUI.activeSelf)
        {
            item.Use();
        }
    }
}
