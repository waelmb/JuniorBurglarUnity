using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;

[CreateAssetMenu(fileName = "Item", menuName = "Item", order = 3)]
public class Item : ScriptableObject
{

    new public string name = "New Item";
    public string description;
    public Sprite artwork;
    public Stat dex;
    public Stat str;
    public bool isDefaultItem = false;

    //Method is virtual, aka defined by subclasses
    public virtual void Use()
    {
        //use the item
        UnityEngine.Debug.Log("using item: " + name);
    }

    public void RemoveFromInventory() {
        Inventory.instance.Remove(this);
    }
}
