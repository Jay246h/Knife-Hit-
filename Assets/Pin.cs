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
            // �̵������� (0, 0, 0)���� ������ �̵�����
            movement2D.MoveTo(Vector3.zero);
            // ���� ���߽� ���ῡ �ڽ��� �Ǿ� ���� ȸ��
            transform.SetParent(collision.transform);
        }
    }
}
