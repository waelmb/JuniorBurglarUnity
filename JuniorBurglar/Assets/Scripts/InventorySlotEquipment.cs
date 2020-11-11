using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventorySlotEquipment : InventorySlot
{
    Inventory inventory;

    void Start()
    {
        inventory = Inventory.instance;
    }

    public new void UseItem()
    {
        UnityEngine.Debug.Log("InventorySlotEquipment: UseItem: " + item.name);

        //unequip item and add to inventory
        //EquipmentManager.instance.Equip(this);
    }
}
