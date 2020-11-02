using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StorageInteracte : MonoBehaviour
{
    public float radius = 2.5f;
    GameObject player;
    GameObject storage;
    public static bool isInRange;

    #region Singleton 
    public static StorageInteracte instance;
    void Awake()
    {
        if (instance != null)
        {
            UnityEngine.Debug.LogWarning("More than one instance of StorageInteracte found");
            return;
        }
        instance = this;
    }
    #endregion

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindWithTag("Player");
        storage = GameObject.FindWithTag("Storage");
    }

    // Update is called once per frame
    void Update()
    {
        if (Vector3.Distance(storage.transform.position, player.transform.position) <= radius)
        {
            isInRange = true;
        }
        else
        {
            isInRange = false;
        }

        //UnityEngine.Debug.Log("StorageInteracte: isInRange " + isInRange);
    }
}
