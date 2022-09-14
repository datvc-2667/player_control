using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    private Transform vehicle;

    private Vector3 offset = new Vector3(0, 5, -20);

    private void Start()
    {
        vehicle = GameObject.FindWithTag("Vehicle").transform;

        Debug.Log(vehicle);
    }

    private void Update()
    {
        transform.position = vehicle.position + offset;
    }
}
