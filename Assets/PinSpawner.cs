using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PinSpawner : MonoBehaviour
{
    public GameObject pinPrefab;


    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Instantiate(pinPrefab, transform.position, Quaternion.identity);
        }
    }
}
