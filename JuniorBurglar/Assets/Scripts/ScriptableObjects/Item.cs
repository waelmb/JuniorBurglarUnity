using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Item", menuName = "Item", order = 3)]
public class Item : ScriptableObject
{
    new public string name = "New Item";
    public string description;
    public int dex;
    public int str;
    public Sprite artwork;
    public bool isDefaultItem = false;
}
