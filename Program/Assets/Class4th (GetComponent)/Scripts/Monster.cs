using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Move))] // ���� Ÿ�� Ŭ������ move�� null�� ����Ű�� �ʵ���
public class Monster : MonoBehaviour
{
    // private �������� inspector�� ����ǰ� �ϰ� ���� ��
    [SerializeField] Move move;

    private void Awake()
    {
        move = GetComponent<Move>();
    }

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.W))
        {
            move.OnMove(Vector3.forward);
        }
        else if (Input.GetKeyDown(KeyCode.A))
        {
            move.OnMove(Vector3.left);
        }
       else if (Input.GetKeyDown(KeyCode.S))
        {
            move.OnMove(Vector3.back);
        }
       else if (Input.GetKeyDown(KeyCode.D))
        {
            move.OnMove(Vector3.right);
        }


    }
}
