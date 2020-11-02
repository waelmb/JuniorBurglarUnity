using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Storage : MonoBehaviour
{
    #region Singleton 
    public static Storage instance;
    void Awake()
    {
        if (instance != null)
        {
            UnityEngine.Debug.LogWarning("More than one instance of Storage found");
            return;
        }
        instance = this;
    }
    #endregion

    public delegate void OnItemChanged();
    public OnItemChanged onItemChangedCallback;

    static public List<Item> items = new List<Item>();

    public int space = 30;

    public bool Add(Item item)
    {
        UnityEngine.Debug.Log("Storage: Adding item: " + item.name);

        if (items.Count >= space)
        {
            UnityEngine.Debug.Log("Storage: Not enough room.");
            return false;
        }

        items.Add(item);

        if (onItemChangedCallback != null)
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

    public void SceneSwitched()
    {
        UnityEngine.Debug.Log("Storage: SceneSwitched. Count: " + items.Count);
        if (onItemChangedCallback != null)
        {
            onItemChangedCallback.Invoke();
        }
    }
}
