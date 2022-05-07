using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class PopUp : MonoBehaviour
{
    public bool playerInRange;
    // public KeyCode interactKey;
    // public UnityEvent interactAction;
    public GameObject popUpBox;
    // public GameObject player;
    public bool show_popUp;

    public void OpenPopUp() {
        show_popUp = true;
        popUpBox.SetActive(show_popUp);
        Debug.Log("Popup is open");
    }

    public void ClosePopUp() {
        show_popUp = false;
        popUpBox.SetActive(show_popUp);
    }

    public void ManualClosePopUp() {
        playerInRange = false;
        show_popUp = false;
        popUpBox.SetActive(show_popUp);
    }

    // Update is called once per frame
    void Update()
    {
        if(playerInRange)
        {
            OpenPopUp();
        } else {
            ClosePopUp();
        }
    }

    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.CompareTag("Fighter"))
        {
            playerInRange = true;
            Debug.Log("Player can see popup");
        }

    }

    private void OnTriggerExit2D(Collider2D col) {
        if (col.gameObject.CompareTag("Fighter"))
        {
            playerInRange = false;
            Debug.Log("Player cannot see popup");
        }
    }
}
