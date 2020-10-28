using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Boots", menuName = "Boots")]
public class NewBoots : ScriptableObject
{
    public string name;
    public string description;
    public int dex;
    public Sprite artwork;
}
