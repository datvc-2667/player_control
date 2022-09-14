using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField]
    private GameObject[] vehiclePrefabs;

    private Vector3 offsetDefault = new Vector3(0,0, -23);

    // Start is called before the first frame update
    void Awake()
    {
        int indexVehicle = Random.Range(0, vehiclePrefabs.Length);
        Instantiate(vehiclePrefabs[indexVehicle], offsetDefault, vehiclePrefabs[indexVehicle].transform.rotation);
    }

    
}
