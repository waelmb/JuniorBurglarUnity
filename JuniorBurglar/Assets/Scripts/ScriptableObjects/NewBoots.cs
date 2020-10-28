using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Item", menuName = "Item/Boots")]
public class NewBoots : ScriptableObject
{
    new public string name;
    public string description;
    public int dex;
    public Sprite artwork;
}
