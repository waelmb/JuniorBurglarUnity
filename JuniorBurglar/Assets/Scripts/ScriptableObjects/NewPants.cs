﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Item", menuName = "Item/Pants")]
public class NewPants : ScriptableObject
{
    new public string name;
    public string description;
    public int dex;
    public int str;
    public Sprite artwork;
}