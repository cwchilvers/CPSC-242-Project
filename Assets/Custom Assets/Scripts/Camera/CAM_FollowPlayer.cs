using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CAM_FollowPlayer : MonoBehaviour
{
	public Transform target;
	public float distance		= 10.0f;
	public float height			= 5.0f;
	public float heightDamping	= 5.0f;

	private float _currentHeight		= 0.0f;
	private float _currentRotationAngle = 0.0f;
	private float _wantedHeight			= 0.0f;

	[AddComponentMenu("Camera-Control/Smooth Follow")]

	void LateUpdate()
	{
		CheckTarget();
		CalculateRotationAngles();
		SetHeight();
		SetTarget();
	}

	private void CheckTarget()
    {
		if (!target) return;
	}

	private void CalculateRotationAngles()
    {
		_currentRotationAngle = transform.eulerAngles.y;
		_currentHeight = transform.position.y;
		_wantedHeight = target.position.y + height;
	}

	private void SetHeight()
    {
		_currentHeight = Mathf.Lerp(_currentHeight, _wantedHeight, heightDamping * Time.deltaTime);
		transform.position = target.position;
		transform.position = new Vector3(transform.position.x, _currentHeight, transform.position.z);
	}

	private void SetTarget()
	{
		transform.LookAt(target);
	}
}

