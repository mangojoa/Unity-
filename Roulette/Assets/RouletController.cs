using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RouletController : MonoBehaviour
{
    float rotSpeed = 0;

    void Start()
    {
            
    }

    void Update()
    {
        // 룰렛을 클릭하는 이벤트가 발생한다면 룰렛 속도 변수를 10으로 설정
        if (Input.GetMouseButtonDown(0))
        {
            this.rotSpeed = 10;
        }

        // 룰렛이 회전하는 방향을 설정하는 Rotate(x, y, z) 함수를 이용해서 회전시킨다.
        transform.Rotate(0, 0, this.rotSpeed);

        // 감쇠 계수 0.96를 곱하여 속도를 점차 감속 시킨다.
        this.rotSpeed *= 0.98f;
    }
}
