using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chest : Collectable
{
    public Sprite emptyChest;
    public int coinAmount = 5;
    protected override void OnCollect()
    {
        if(!collected) {
            collected = true;
            GetComponent<SpriteRenderer>().sprite = emptyChest;
            GameManager.instance.ShowText("+" + coinAmount + " coins", 25, Color.white, transform.position, Vector3.up * 25, 1.5f);
            // if want to make it our own color define it as new Color() nums btwn 0-1
            //Debug.Log("Grant " + coinAmount + " coins!");
        }
        // base.OnCollect();
        // Debug.Log("Grant loot");
    }
}
