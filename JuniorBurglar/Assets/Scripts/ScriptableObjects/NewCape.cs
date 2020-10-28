using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Item", menuName = "Item/Cape")]
public class NewCape : ScriptableObject
{
    new public string name;
    public string description;
    public int dex;
    public Sprite artwork;
}

