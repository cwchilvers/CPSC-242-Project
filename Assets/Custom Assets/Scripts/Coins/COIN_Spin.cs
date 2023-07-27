using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class COIN_Spin : MonoBehaviour
{
    public Transform coinTransform;

    private float _rotationSpeed = Constants.COIN_ROTATION_SPEED;

    void Update()
    {
        Rotate();
    }

    private void Rotate()
    {
        coinTransform.Rotate(0, _rotationSpeed * Time.deltaTime, 0, Space.World);
    }
}
