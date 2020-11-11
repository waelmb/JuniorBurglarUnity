using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EquipmentManager : MonoBehaviour
{

    #region Singleton
    public static EquipmentManager instance;

    private void Awake()
    {
        instance = this;
    }
    #endregion

    public static Equipment[] currentEquipment;

    public delegate void OnEquipmentChanged(Equipment newItem, Equipment oldItem);
    public OnEquipmentChanged onEquipmentChanged;

    Inventory inventory;

    void Start()
    {
        inventory = Inventory.instance;

        int numSlots = System.Enum.GetNames(typeof(EquipmentSlot)).Length;

        if (currentEquipment == null)
        {
            currentEquipment = new Equipment[numSlots];
        }
        else
        {
            OnSceneChanged(numSlots);
        }
    }

    void OnSceneChanged(int numSlots)
    {
        Equipment[] temp = new Equipment[numSlots];

        //unequip all
        for (int i = 0; i < currentEquipment.Length; i++)
        {
            Equipment oldItem = currentEquipment[i];
            temp[i] = oldItem;
            if (onEquipmentChanged != null)
            {
                onEquipmentChanged.Invoke(null, oldItem);
            }
        }

        //equip all
        for (int i = 0; i < currentEquipment.Length; i++)
        {
            Equipment newItem = temp[i];
            currentEquipment[i] = newItem;
            if (onEquipmentChanged != null)
            {
                onEquipmentChanged.Invoke(newItem, null);
            }
        }

    }

    public void Equip(Equipment newItem) {
        int slotIndex = (int)newItem.equipSlot;

        Equipment oldItem = null;

        if (currentEquipment[slotIndex] != null) {
            oldItem = currentEquipment[slotIndex];
            inventory.Add(oldItem);
        }

        if (onEquipmentChanged != null) {
            onEquipmentChanged.Invoke(newItem, oldItem);
        }
        currentEquipment[slotIndex] = newItem;
    }

    public void Unequip(int slotIndex) {
        if (currentEquipment[slotIndex] != null) {
            Equipment oldItem = currentEquipment[slotIndex];
            inventory.Add(oldItem);

            currentEquipment[slotIndex] = null;

            if (onEquipmentChanged != null)
            {
                onEquipmentChanged.Invoke(null, oldItem);
            }
        }
    }

    public void UnequipAll() {
        for (int i = 0; i < currentEquipment.Length; i++) {
            Unequip(i);
        }
    }

    private void Update() {
        // Keystroke U unequips all equipment.
        if (Input.GetKeyDown(KeyCode.U)) {
            UnequipAll();
        }
    }

    public void UpdateEquipmentUI()
    {
        //UnityEngine.Debug.Log("Inventory: SceneSwitched. Count: " + items.Count);
        if (onEquipmentChanged != null && currentEquipment != null)
        {
            onEquipmentChanged.Invoke(null, null);
        }
    }

}
