using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChestCollide : Collectable
{
    public Sprite emptyChest;

    protected override void Collect()
    {
        if(collected == false)
        {
            base.Collect();
            GetComponent<SpriteRenderer>().sprite = emptyChest;
        }
        
        Debug.Log("Working!");
    }
}
