using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AirCraft : MonoBehaviour
{
    [SerializeField] float speed = 1.0f;
    [SerializeField] Vector3 direction;
   
    // 안 쓰는 이벤트 함수를 놔두면, 안 쓰더라도 룩업 테이블에 올라가기 때문에 성능 저하돼서 삭제 굿
  
    void Update()
    {
        direction.x = Input.GetAxis("Horizontal");
        direction.z = Input.GetAxis("Vertical");

        direction.Normalize(); // 대각선 방향이 루트 2가 되는 것을 방지하기 위한 벡터의 정규화 

        transform.Translate(direction * speed * Time.deltaTime);

        // P(다음 이동할 위치)  = P0(현 위치) + v(속도)t(시간) 
        // transform.position = transform.position + direction * speed * Time.deltaTime;
                                        // 벡터의 정규화로 방향 고정, 속도 일정
    }
}
