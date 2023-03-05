using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarController : MonoBehaviour
{

    // 차의 속력을 위한 변수
    float carSpeed = 0;

    // 스와아프 조작을 위한 vector 사용
    Vector2 startPos;

    void Start()
    {
        
    }

    void Update()
    {

        if (Input.GetMouseButtonDown(0))
        {
            this.startPos = Input.mousePosition;
        }
        else if (Input.GetMouseButtonUp(0))
        {
            Vector2 endPos = Input.mousePosition;

            float swipeLength = endPos.x - startPos.x;

            this.carSpeed = swipeLength / 500.0f;

            GetComponent<AudioSource>().Play();
        }

        transform.Translate(this.carSpeed, 0, 0);

        this.carSpeed *= 0.98f;
    }
}
