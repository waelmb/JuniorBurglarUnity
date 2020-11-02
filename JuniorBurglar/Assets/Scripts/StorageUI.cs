using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StorageUI : MonoBehaviour
{
    Storage storage;
    StorageInteracte storageInteract;
    public Transform itemsParent;
    InventorySlot[] slots;
    public GameObject storageUI;

    // Start is called before the first frame update
    void Start()
    {
        storage = Storage.instance;
        storageInteract = StorageInteracte.instance;
        storage.onItemChangedCallback += UpdateUI;
        slots = itemsParent.GetComponentsInChildren<InventorySlot>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Storage") && StorageInteracte.isInRange)
        {
            storageUI.SetActive(!storageUI.activeSelf);
        }

        if(storageUI.activeSelf && !StorageInteracte.isInRange)
        {
            storageUI.SetActive(false);
        }
    }

    void UpdateUI()
    {
        UnityEngine.Debug.Log("Storage: UpdateUI");
        for (int i = 0; i < slots.Length; i++)
        {
            if (i < Storage.items.Count)
            {
                slots[i].AddItem(Storage.items[i]);
            }
            else
            {
                slots[i].ClearSlot();
            }
        }
    }
}
