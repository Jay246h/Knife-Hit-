using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Target : MonoBehaviour
{
    private float rotateSpeed = 100f;
    private Vector3 rotateAngle = Vector3.forward; 


    void Update()
    {
        transform.Rotate(rotateAngle *  rotateSpeed * Time.deltaTime);
    }
}
