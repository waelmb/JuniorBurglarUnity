using UnityEngine;
using UnityEngine.UI;

public class InventorySlot : MonoBehaviour
{
    Item item;
    public Image icon;
    public Button removeButton;

    public void AddItem(Item newItem)
    {
        item = newItem;
        icon.sprite = item.artwork;
        icon.enabled = true;
        removeButton.interactable = true;
    }

    public void ClearSlot()
    {
        item = null;
        icon.sprite = null;
        icon.enabled = false;
        removeButton.interactable = false;
    }

    public void onRemoveButton()
    {
        UnityEngine.Debug.Log("onRemoveButton: " + item.name);
        Inventory.instance.Remove(item);
    }

    public void UseItem()
    {
        UnityEngine.Debug.Log("UseItem: " + item.name);
        if (item != null)
        {
            item.Use();
        }
    }
}
