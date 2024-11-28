using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Target : MonoBehaviour
{
    private float rotateSpeed = 100f;
    private Vector3 rotateAngle = Vector3.forward; 

     private IEnumerator Start()
    {
        while (true)
        {
            int time = Random.Range(1, 5);
            yield return new WaitForSeconds(time);

            int speed = Random.Range(10, 300);
            int dir = Random.Range(0, 2);

            rotateSpeed = speed;
            rotateAngle = new Vector3(0, 0, dir * 2-1);
        }
    }
    void Update()
    {
        transform.Rotate(rotateAngle *  rotateSpeed * Time.deltaTime);
    }
}
