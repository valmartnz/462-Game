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

    public bool show_shop;
    public bool show_player;

    private void Update()
    {
        // Open or close shop by pressing "F"
        if (Input.GetKeyDown(KeyCode.F))
        {
            show_shop = !show_shop;
            shop_window.SetActive(show_shop);


            // show_player = !show_player;
            // player.GetComponent<SpriteRenderer>().enabled = show_player;
        }

    }

}
