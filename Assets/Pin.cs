using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Pin : MonoBehaviour
{
    [SerializeField]
    private Transform hitEffectSpawnPoint;
    [SerializeField]
    private GameObject hitEffectPrefab;
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
            collision.GetComponent<Target>().Hit();

            Instantiate(hitEffectPrefab, hitEffectSpawnPoint.position, hitEffectSpawnPoint.rotation);

            // �����Ƽ� Camera.main�� ������ PinSpawner���� ShakeCamera ������ �̸� �޾Ƶΰ�,
            // Pin�� ������ �� Pin.Setup(shakeCamera); �� ���� �޾ƿͼ� ���� �� ����
            Camera.main.GetComponent<ShakeCamera>().Shake(0.1f, 1);

            // ���ῡ ��ġ�� ���� OnTriggerEnter2D()�� ȣ������ �ʵ��� ��ũ��Ʈ ����
            Destroy(this);
        }
        else if (collision.CompareTag("Pin"))
        {
            Debug.Log("�� �� �ٽ���");
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }
}
