using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    Rigidbody2D rigi2D;
    // 점프하는 힘
    float jumpForce = 680.0f;
    // 움직이는 힘
    float walkForce = 30.0f;
    // 움직이는 힘의 최대값
    float maxWalkSpeed = 2.0f;
    void Start()
    {
        this.rigi2D = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            this.rigi2D.AddForce(transform.up * this.jumpForce);
        }

        // 좌우이동
        int key = 0;
        if (Input.GetKey(KeyCode.RightArrow)) key = 1;
        if (Input.GetKey(KeyCode.LeftArrow)) key = -1;

        // 플레이어 속도 계산
        float speedx = Mathf.Abs(this.rigi2D.velocity.x);

        // 스피드 제한
        if (speedx < this.maxWalkSpeed)
        {
            this.rigi2D.AddForce(transform.right * key * this.walkForce);
        }

        // 움직이는 방향에 따라 반전
        if (key != 0)
        {
            transform.localScale = new Vector3(key, 1, 1);
        }
    }
}
