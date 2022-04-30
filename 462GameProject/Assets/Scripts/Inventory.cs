using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Inventory : MonoBehaviour
{
    public List<GameObject> items = new List<GameObject>();
    [Header("UI Items Section")]
    public GameObject ui_window;
    // public GameObject shop_window;
    public Image[] item_image;
    public GameObject player;

    public bool show_inv;
    public bool show_shop;
    public bool show_player;

    public int money = 0;
    public Text moneyText;

    public void updateMoney(int m) {
        money += m;
    }

    private void Update()
    {
        moneyText.text = "Money: " + money;

        //Open or close inventory by pressing "E"
        if (Input.GetKeyDown(KeyCode.E))
        {
            show_inv = !show_inv;
            ui_window.SetActive(show_inv);


            show_player = !show_player;
            player.GetComponent<SpriteRenderer>().enabled = show_player;
        }

        //Open or close shop by pressing "F"
        // if (Input.GetKeyDown(KeyCode.F))
        // {
        //     show_shop = !show_shop;
        //     shop_window.SetActive(show_shop);


        //     show_player = !show_player;
        //     player.GetComponent<SpriteRenderer>().enabled = show_player;
        // }

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
