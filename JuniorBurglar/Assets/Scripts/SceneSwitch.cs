using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneSwitch : MonoBehaviour
{
    public string sceneToLoad;

    public void OnTriggerEnter(Collider other)
    {
        UnityEngine.Debug.Log("here");

        if (other.gameObject.layer == LayerMask.NameToLayer("Player"))
        {
            SceneManager.LoadScene(sceneToLoad);
        }
    }
}
