using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    private Transform vehicle;

    private Vector3 offset = new Vector3(8, 5, -27);

    private void Start()
    {
        vehicle = GameObject.FindWithTag("Human").transform;
    }

    private void Update()
    {
        transform.position = vehicle.position + offset;
    }
}
