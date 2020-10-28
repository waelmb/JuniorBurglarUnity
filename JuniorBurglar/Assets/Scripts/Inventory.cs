﻿using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;

public class Inventory : MonoBehaviour
{

    #region Singleton 
    public static Inventory instance;
    void Awake()
    {
        if(instance != null)
        {
            UnityEngine.Debug.LogWarning("More than one instance of Inventory found");
            return;
        }
        instance = this;
    }
    #endregion

    public delegate void OnItemChanged();
    public OnItemChanged onItemChangedCallback;

    public List<Item> items = new List<Item>();

    public int space = 6;

    public bool Add(Item item)
    {
        if(items.Count >= space)
        {
            UnityEngine.Debug.Log("Not enough room.");
            return false;
        }

        items.Add(item);
        
        if(onItemChangedCallback != null)
        {
            onItemChangedCallback.Invoke();
        }

        return true;
    }

    public void Remove(Item item)
    {
        items.Remove(item);

        if (onItemChangedCallback != null)
        {
            onItemChangedCallback.Invoke();
        }
    }
}