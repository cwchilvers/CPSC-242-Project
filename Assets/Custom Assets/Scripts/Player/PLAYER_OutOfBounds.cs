using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PLAYER_OutOfBounds : MonoBehaviour
{
    public Collider player;
    public AudioSource playerAudio;
    public AudioClip scream;
    public PLAYER_Explode playerExplode;


    void OnCollisionEnter(Collision _other)
    {
        if (_other.gameObject.tag == "Scream")
        {
            playerAudio.PlayOneShot(scream, 1f);
        }

        if (_other.gameObject.tag == "Kill")
        {
            KillPlayer();
        }
    }

    public void KillPlayer()
    {
        playerExplode.isDead = true;
        playerExplode.Explode();
    }
}