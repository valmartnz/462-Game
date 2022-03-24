using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemPickup : MonoBehaviour
{
    public AudioClip audio_clip;
    

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag == "Item")
        {
            AudioSource.PlayClipAtPoint(audio_clip, transform.position);
            Destroy(col.gameObject);
        }
    }
}
