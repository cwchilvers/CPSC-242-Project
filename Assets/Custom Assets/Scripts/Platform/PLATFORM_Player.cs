using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PLATFORM_Player : MonoBehaviour
{
    public GameObject player;
    public GameObject platform;

    void OnCollisionEnter()
    {
        player.transform.parent = platform.transform;
    }

    void OnCollisionExit(Collision col)
    {
        player.transform.parent = null;
    }
}
