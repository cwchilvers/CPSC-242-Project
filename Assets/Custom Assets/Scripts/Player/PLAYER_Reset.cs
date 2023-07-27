using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PLAYER_Reset : MonoBehaviour
{
    public GameObject player;
    public Transform spawner;
    public GameObject finish;

    private float _timer;
    private float _time = 4.0f;
    private bool _isResetting = false;

    private void FixedUpdate()
    {
        if (_isResetting == true)
        {
            UpdateTimer();
            if (_timer >= _time)
            {
                _isResetting = false;
                _timer = 0;
                RespawnPlayer();
            }
        }
    }

    public void Reset()
    {
        _isResetting = true;
        HidePlayer();
    }

    private void UpdateTimer()
    {
        if (_timer < _time)
        {
            _timer += Time.deltaTime;
        }
    }

    private void HidePlayer()
    {
        player.SetActive(false);
    }

    private void RespawnPlayer()
    {
        player.transform.position = spawner.position; 
        player.SetActive(true);
        finish.SetActive(false);
    }
}
