using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{              
  public void OnMove(Vector3 direction) // 이벤트로 발생하는 함수들은 거의 전치사 'On' 사용
    {
        transform.position += direction;
    }
}
