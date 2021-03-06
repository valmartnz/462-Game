using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemPickupAudio : MonoBehaviour
{
    public AudioClip audio_clip;

    void OnTriggerEnter2D(Collider2D col)
    {

        //Play audio picking up item
        if (col.gameObject.tag == "Item")
        {
            AudioSource.PlayClipAtPoint(audio_clip, transform.position);
        }
    }
}
