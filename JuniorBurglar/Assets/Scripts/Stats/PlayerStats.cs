using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStats : CharacterStats
{
    void Start(){
        EquipmentManager.instance.onEquipmentChanged += OnEquipmentChanged;
    }

    
    void OnEquipmentChanged(Equipment newItem, Equipment oldItem) {

        if (newItem != null) {
            dex.AddModifier(newItem.dexmodifier);
            str.AddModifier(newItem.strmodifier);
        }

        if (oldItem != null) {
            dex.RemoveModifier(oldItem.dexmodifier);
            str.RemoveModifier(oldItem.strmodifier);
        }
    }

  
}
