using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneSwitch : MonoBehaviour
{
    public string sceneToLoad;
    //public Vector2 playerPosition;
    //public VectorValue playerStorage;

    void OnTriggerEnter2D(Collider2D other)
    {
        UnityEngine.Debug.Log("here onTrigger");

        if (other.gameObject.layer == LayerMask.NameToLayer("Player"))
        {
            //playerStorage.initialVlaue = playerPosition;
            SceneManager.LoadScene(sceneToLoad);
        }
    }

    /*
    void OnCollisionEnter2D(Collision2D collision)
    {
        UnityEngine.Debug.Log("here onCollision");
        print("here onCollision print");
    }
    https://stackoverflow.com/questions/18281385/oncollisionenter-not-working-in-unity3d
    */
}
