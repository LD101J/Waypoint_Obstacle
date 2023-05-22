using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Waypoints : MonoBehaviour
{
    #region
    [SerializeField] private Transform[] waypoints;
    [SerializeField] private float moveSpeed;
     private int waypointIndex;
    #endregion
    private void Start()
    {
        transform.position = waypoints[waypointIndex].transform.position;
    }
    private void Update()
    {
        Waypoint_Mover();
    }

    private void Waypoint_Mover()
    {
        transform.position = Vector2.MoveTowards(transform.position, waypoints[waypointIndex].transform.position,  moveSpeed * Time.deltaTime);
        if(transform.position == waypoints[waypointIndex].transform.position)
        {
            waypointIndex += 1;
        }
        if(waypointIndex == waypoints.Length)
        {
            waypointIndex = 0;  
        }
    }
}
