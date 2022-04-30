using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collidable : MonoBehaviour
{
    public ContactFilter2D filter;
    private BoxCollider2D boxCollider;
    private PolygonCollider2D polyCollider;

    private Collider2D[] hits = new Collider2D[10];

    protected virtual void Start() {
        boxCollider = GetComponent<BoxCollider2D>();
        polyCollider = GetComponent<PolygonCollider2D>();
    }

    protected virtual void Update() {
        // collision work
        boxCollider.OverlapCollider(filter, hits);
        polyCollider.OverlapCollider(filter, hits);
        
        for(int i = 0; i < hits.Length; i++) {
            if(hits[i] == null)
                continue;
            
            OnCollide(hits[i]);

            // clean up array
            hits[i] = null;
        }
    }

    protected virtual void OnCollide(Collider2D coll) {
        Debug.Log("OnCollide needs to be updated for " + this.name);
    }
}
