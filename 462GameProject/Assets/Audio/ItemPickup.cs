using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemPickup : MonoBehaviour
{
    public AudioClip audio_clip;


    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Item")
        {
            AudioSource.PlayClipAtPoint(audio_clip, transform.position);
            Debug.Log("teas");
        }
    }
}
