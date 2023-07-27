using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;

public class CAM_DragMouse : MonoBehaviour
{
    void Start()
    {
        CinemachineCore.GetInputAxis = GetMouseAxis;
    }

    public float GetMouseAxis(string axisName)
    {
        if (axisName == "Mouse X")
        {
            if (Input.GetMouseButton(0))
                return UnityEngine.Input.GetAxis("Mouse X");
            else
                return 0;
        }
        else if (axisName == "Mouse Y")
        {
            if (Input.GetMouseButton(0))
                return UnityEngine.Input.GetAxis("Mouse Y");
            else
                return 0;
        }
        return UnityEngine.Input.GetAxis(axisName);
    }
}
