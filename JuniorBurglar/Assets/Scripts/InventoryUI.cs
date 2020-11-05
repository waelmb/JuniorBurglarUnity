using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;

public class InventoryUI : MonoBehaviour
{
    Inventory inventory;
    public Transform itemsParent;
    InventorySlot[] slots;
    public GameObject inventoryUI;

    // Start is called before the first frame update
    void Start()
    {
        inventory = Inventory.instance;
        inventory.onItemChangedCallback += UpdateUI;
        slots = itemsParent.GetComponentsInChildren<InventorySlot>();

        //update inventory
        Inventory.instance.UpdateInventoryUI();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Inventory"))
        {
            inventoryUI.SetActive(!inventoryUI.activeSelf);
        }
    }

    void UpdateUI()
    {
        UnityEngine.Debug.Log("UpdateUI");
        for(int i = 0; i < slots.Length; i++)
        {
            if(i < Inventory.items.Count)
            {
                slots[i].AddItem(Inventory.items[i]);
            }
            else
            {
                slots[i].ClearSlot();
            }
        }
    }
}
