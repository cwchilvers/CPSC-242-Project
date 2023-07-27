using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class COIN_Destroy : MonoBehaviour
{
    public GameObject scoreScript;
    public AudioSource playerAudio;
    public AudioClip coin;

    public void OnTriggerEnter(Collider other)
    {
        scoreScript.GetComponent<Score>().UpdateScore();
        playerAudio.PlayOneShot(coin, 1f);
        Destroy(gameObject);
    }
}
