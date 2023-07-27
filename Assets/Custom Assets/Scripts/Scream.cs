using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scream : MonoBehaviour
{
    public Collider player;
    public AudioSource playerAudio;
    public AudioClip scream;


    void OnTriggerEnter(Collider _other)
    {
        if (_other.gameObject.tag == "Player")
        {
            playerAudio.PlayOneShot(scream, 1f);
        }
    }
}
