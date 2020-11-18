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

        for(int i = 0; i < EquipmentManager.currentEquipment.Length; i++)
        {
            if(EquipmentManager.currentEquipment[i] == item)
            {
                //UnityEngine.Debug.Log("item slot is " + i);
                EquipmentManager.instance.Unequip(i);
            }
        }
        //unequip item and add to inventory
        //EquipmentManager.instance.Equip(this);
    }
}
