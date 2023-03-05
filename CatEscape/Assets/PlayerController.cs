using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    void Start()
    {
        
    }

    void Update()
    {
        /* 키가 눌렸는지 검사하는 메소드
         * Input.GetKeyDown()
         * 매개변수로 전달하는 키가 눌리는 순간을 ture를 한 번 반환
         * 이전에 배운 GetMouseButtonDown 메서드와 비슷한 개념
         */

        // 왼쪽 버튼을 클릭시 캐릭터의 좌표를 -3 시킨다
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            transform.Translate(-3, 0, 0);
        }

        // 오른쪽 버튼을 클릭시 캐릭터의 좌표를 3 시킨다.
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            transform.Translate(3, 0, 0);
        }
    }
}
