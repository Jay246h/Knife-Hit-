using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pin : MonoBehaviour
{
    private Movement2D movement2D;

    private void Awake()
    {
        movement2D = GetComponent<Movement2D>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Target"))
        {
            // 이동방향을 (0, 0, 0)으로 설정해 이동중지
            movement2D.MoveTo(Vector3.zero);
            // 과녁 적중시 과녁에 자식이 되어 같이 회전
            transform.SetParent(collision.transform);
        }
    }
}
