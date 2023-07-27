using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PLATFORM_Move : MonoBehaviour
{
    [SerializeField] private List<Transform> waypoints;
    [SerializeField] private float moveSpeed = Constants.PLATFORM_MOVE_SPEED;
    private int _currentWaypoint;

    private void Start()
    {
        if (waypoints.Count <= 0) return;
        _currentWaypoint = 0;
    }

    private void FixedUpdate()
    {
        MovePlatform();
        CheckWaypoint();
    }

    private void MovePlatform()
    {
        transform.position = Vector3.MoveTowards(transform.position, waypoints[_currentWaypoint].transform.position, (moveSpeed * Time.deltaTime));
    }

    private void CheckWaypoint()
    {
        if (Vector3.Distance(waypoints[_currentWaypoint].transform.position, transform.position) <= 0)
            _currentWaypoint++;

        if (_currentWaypoint != waypoints.Count) return;
        waypoints.Reverse();
        _currentWaypoint = 0;
    }
}
