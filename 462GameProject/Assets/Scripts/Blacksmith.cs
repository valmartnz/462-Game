using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Blacksmith : MonoBehaviour
{
    public List<GameObject> items = new List<GameObject>();
    [Header("UI Items Section")]
    // public GameObject ui_window;
    public GameObject shop_window;
    public GameObject player;
    public bool playerInRange;

    public bool show_shop;
    public bool show_player;

    public void OpenShop() {
        show_shop = !show_shop;
        shop_window.SetActive(show_shop);
        Debug.Log("Shop is open");
    }

    // private void Update()
    // {
    //     // Open or close shop by pressing "F"
    //     if(playerInRange)
    //     {
    //         if (Input.GetKeyDown(KeyCode.F))
    //         {
    //         show_shop = !show_shop;
    //         shop_window.SetActive(show_shop);


    //         // show_player = !show_player;
    //         // player.GetComponent<SpriteRenderer>().enabled = show_player;
    //         }
    //     }

    // }

    // private void OnTriggerEnter2D(Collider2D col)
    // {
    //     if (col.gameObject.CompareTag("Fighter"))
    //     {
    //         playerInRange = true;
    //         Debug.Log("Player is in range");
    //     }

    // }

    // private void OnTriggerExit2D(Collider2D col) {
    //     if (col.gameObject.CompareTag("Fighter"))
    //     {
    //         playerInRange = false;
    //         Debug.Log("Player not in range");
    //     }
    // }

}
