using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LAVA_KillPlayer : MonoBehaviour
{
    public GameObject player;
    public AudioSource playerAudio;
    public AudioClip playerDie;
    public PLAYER_Explode playerExplode;

    void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "Player")
        {
            playerExplode.isDead = true;
            playerAudio.PlayOneShot(playerDie, 1f);
            playerExplode.Explode();
        }
    }
}
