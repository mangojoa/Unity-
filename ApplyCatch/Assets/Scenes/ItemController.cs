using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemController : MonoBehaviour
{

    public float dropSpeed = -0.01f;
    
    void Update()
    {
        transform.Translate(0, this.dropSpeed, 0);

        // 아이템이 무대 라래로 내려가 보이지 않으면?
        // 아이템을 소멸시키도록 한다.
        if (transform.position.y < -1.0f)
        {
            Destroy(gameObject);
        }
    }
}
