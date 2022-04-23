using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Inventory : MonoBehaviour
{
    public List<GameObject> items = new List<GameObject>();
    [Header("UI Items Section")]
    public GameObject ui_window;
    public Image[] item_image;
    public GameObject player;

    public bool show_inv;
    public bool show_player;

    private int money = 0;
    public Text moneyText;

    private void Update()
    {
        moneyText.text = "Money: " + money;

        //Open or close inventory by pressing "I"
        if (Input.GetKeyDown(KeyCode.I))
        {
            show_inv = !show_inv;
            ui_window.SetActive(show_inv);


            show_player = !show_player;
            player.GetComponent<SpriteRenderer>().enabled = show_player;
        }

    }


    // Interactions with items on ground
    void OnTriggerEnter2D(Collider2D col)
    {
        //Pickup items to inventory
        if (col.gameObject.tag == "Item")
        {
            items.Add(col.gameObject);
            col.gameObject.SetActive(false);
            Update_UI();
        }

        //Add money to currency
        if (col.gameObject.tag == "Money")
        {
            money += 10;
            col.gameObject.SetActive(false);
            Update_UI();
        }
    }


    //Add item image to inventory
    void Update_UI()
    {
        hide_images();
        for (int i = 0; i < items.Count; i++)
        {
            item_image[i].sprite = items[i].GetComponent<SpriteRenderer>().sprite;
            item_image[i].gameObject.SetActive(true);
        }
    }

    //Hide the palceholder image in inventory
    void hide_images()
    {
        foreach (var i in item_image)
        {
            i.gameObject.SetActive(false);
        }
    }
}
