using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Blacksmith : MonoBehaviour
{
    
    public GameObject shop_window;
    public bool playerInRange;

    public bool show_shop;

    public void OpenShop() {
        show_shop = !show_shop;
        shop_window.SetActive(show_shop);
        Debug.Log("Shop is open");
    }

}
