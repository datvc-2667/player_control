using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    [SerializeField]
    private GameObject[] obstaclePrefab;

    private Vector3 spawPos = new Vector3(25, 0, 0);

    private float startDelay = 2;
    private float repeatRate = 2;

    private void Start()
    {
        InvokeRepeating("SpawnObstacle", startDelay, repeatRate);  
    }


    // Update is called once per frame
    private void SpawnObstacle()
    {
        int spawIndex = Random.Range(0, obstaclePrefab.Length);
        Instantiate(obstaclePrefab[spawIndex], spawPos, obstaclePrefab[spawIndex].transform.rotation);
    }
}
