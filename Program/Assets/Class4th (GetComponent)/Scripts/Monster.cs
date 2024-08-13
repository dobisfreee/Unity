using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Move))] // 참조 타입 클래스인 move가 null을 가르키지 않도록
public class Monster : MonoBehaviour
{
    // private 변수지만 inspector에 노출되게 하고 싶을 때
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
