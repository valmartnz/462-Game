using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collide : MonoBehaviour
{
    public ContactFilter2D filter;
    private BoxCollider2D boxCollider;
    private Collider2D[] numhits = new Collider2D[10];
    // Start is called before the first frame update
    protected virtual void Start()
    {
        boxCollider = GetComponent<BoxCollider2D>();
    }

    // Update is called once per frame
    protected virtual void Update()
    {
        boxCollider.OverlapCollider(filter, numhits);
        for (int i = 0; i < numhits.Length; i++)
        {
            if (numhits[i] == null)
                continue;

            //we can cause NPC to pop up
            OnCollision(numhits[i]);
        }
    }

    protected virtual void OnCollision(Collider2D coll)
    {

    }
}
