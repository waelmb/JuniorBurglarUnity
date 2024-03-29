﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Equipment", menuName = "Inventory/Equipment")]
public class Equipment : Item
{
    public EquipmentSlot equipSlot;
    public float dexmodifier;
    public float strmodifier;

    public override void Use()
    {
        base.Use();
        //Equip item
        EquipmentManager.instance.Equip(this);
        //Remove it from the inventory
        RemoveFromInventory();

    }
}

public enum EquipmentSlot { Head, Chest, Legs, Boots}