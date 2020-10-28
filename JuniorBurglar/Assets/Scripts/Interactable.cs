using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interactable : MonoBehaviour
{
    public float radius = 3f;
    bool isFocus = false;
    bool hasInteracted = false;
    Transform player;
    public Transform interactionTransform;


     void Update()
    {
        if (isFocus && !hasInteracted) {
            float distance = Vector3.Distance(player.position, interactionTransform.position);
            if (distance <= radius) {
                Debug.Log("Interact");
                hasInteracted = true;
            }
        }
    }


    private void OnDrawGizmosSelected()
    {
        if (interactionTransform == null)
            interactionTransform = transform;

        Gizmos.color = Color.yellow;
        Gizmos.DrawWireSphere(interactionTransform.position, radius);
    }

    public virtual void Interact() {
        // This method is meant to be overwritten
        Debug.Log("Interacting  with " + transform.name);
    }
}
