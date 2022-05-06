using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PotionShop : MonoBehaviour
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
}
