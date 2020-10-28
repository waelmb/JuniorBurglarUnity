using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Item", menuName = "Item/OrdinaryItem")]
public class OrdinaryItem : ScriptableObject
{
    new public string name;
    public string description;
    public Sprite artwork;
}
