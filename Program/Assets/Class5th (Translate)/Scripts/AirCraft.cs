using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AirCraft : MonoBehaviour
{
    [SerializeField] float speed = 1.0f;
    [SerializeField] Vector3 direction;
   
    // �� ���� �̺�Ʈ �Լ��� ���θ�, �� ������ ��� ���̺� �ö󰡱� ������ ���� ���ϵż� ���� ��
  
    void Update()
    {
        direction.x = Input.GetAxis("Horizontal");
        direction.z = Input.GetAxis("Vertical");

        direction.Normalize(); // �밢�� ������ ��Ʈ 2�� �Ǵ� ���� �����ϱ� ���� ������ ����ȭ 

        transform.Translate(direction * speed * Time.deltaTime);

        // P(���� �̵��� ��ġ)  = P0(�� ��ġ) + v(�ӵ�)t(�ð�) 
        // transform.position = transform.position + direction * speed * Time.deltaTime;
                                        // ������ ����ȭ�� ���� ����, �ӵ� ����
    }
}
