using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Finish : MonoBehaviour
{
    public GameObject player;
    public GameObject finish;
    public AudioSource playerAudio;
    public AudioClip playerDie;
    public AudioClip finishSound;
    public PLAYER_Explode playerExplode;

    void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "Player")
        {
            playerExplode.isDead = true;
            playerAudio.PlayOneShot(finishSound, 1f);
            playerAudio.PlayOneShot(playerDie, 1f);
            playerExplode.Explode();
            finish.SetActive(true);
        }
    }
}