using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Interactable : MonoBehaviour
{
    public bool playerInRange;
    public KeyCode interactKey;
    public UnityEvent interactAction;


    // Update is called once per frame
    void Update()
    {
        if(playerInRange)
        {
            if(Input.GetKeyDown(interactKey))
            {
                interactAction.Invoke();
            }
        }
    }

    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.CompareTag("Fighter"))
        {
            playerInRange = true;
            Debug.Log("Player is in range");
        }

    }

    private void OnTriggerExit2D(Collider2D col) {
        if (col.gameObject.CompareTag("Fighter"))
        {
            playerInRange = false;
            Debug.Log("Player not in range");
        }
    }
}
