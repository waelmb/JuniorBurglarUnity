using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EquipmentUI : MonoBehaviour
{
    EquipmentManager equipmentManager;
    public Transform itemsParent;
    InventorySlot[] slots;
    public GameObject equipmentUI;

    // Start is called before the first frame update
    void Start()
    {
        equipmentManager = EquipmentManager.instance;
        EquipmentManager.instance.onEquipmentChanged += UpdateUI;
        slots = itemsParent.GetComponentsInChildren<InventorySlot>();

        //update inventory
        EquipmentManager.instance.UpdateEquipmentUI();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Inventory"))
        {
            equipmentUI.SetActive(!equipmentUI.activeSelf);
        }
    }

    void UpdateUI(Equipment newItem, Equipment oldItem)
    {
        UnityEngine.Debug.Log("EquipmentUI: UpdateUI");
        for (int i = 0; i < slots.Length; i++)
        {
            if (EquipmentManager.currentEquipment[i] != null)
            {
                slots[i].AddItem(EquipmentManager.currentEquipment[i]);
            }
            else
            {
                slots[i].ClearSlot();
            }
        }
    }
}
