using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PLAYER_Explode : MonoBehaviour
{
    public GameObject   player;
    public GameObject   resetScript;
    public bool isDead  = false;

    public GameObject   obj1;
    public GameObject   obj2;
    public GameObject   obj3;
    public GameObject   explosion;

    public void Explode()
    {
        if (isDead == true)
        {
            isDead = false;
            player.GetComponent<Rigidbody>().velocity = Vector3.zero;
            GameObject _explosion = Instantiate(explosion, transform.position, transform.rotation);
            Destroy(_explosion, 5);
            resetScript.GetComponent<PLAYER_Reset>().Reset();
        }
    }
}