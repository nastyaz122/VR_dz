using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movee : MonoBehaviour
{
    public float speed = 5f;
    private bool movingForward = false;

    private void Update()
    {
        // ��������� ������� ������ W ��� S ��� �������� ������ ��� �����
        float moveDirection = Input.GetAxis("Vertical");

        // �������� ������
        if (moveDirection > 0)
        {
            movingForward = true;
            transform.Translate(Vector3.forward * speed * Time.deltaTime);
        }
        // �������� �����
        else if (moveDirection < 0)
        {
            movingForward = false;
            transform.Translate(-Vector3.forward * speed * Time.deltaTime);
        }

        // �������������� ������� ��� �������� �����
        if (!movingForward)
        {
            transform.rotation = Quaternion.Euler(0f, 180f, 0f);
        }
        else
        {
            transform.rotation = Quaternion.identity;
        }
    }
}
