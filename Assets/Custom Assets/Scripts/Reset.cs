using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Reset : MonoBehaviour
{
    public GameObject playerPrefab;
    private float _timer = 0;
    private bool _isDead = false;

    void FixedUpdate()
    {
        if (_isDead == true)
        {
            UpdateTimer();
        }
    }

    private void UpdateTimer()
    {
        _timer -= Time.deltaTime;

        if (_timer > 5)
        {
            _isDead = false;
        }
    }

    private void ResetPlayer()
    {
        _timer = 0;
    }
}
