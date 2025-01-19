using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemGenerator : MonoBehaviour
{

    public GameObject applePrefab;
    public GameObject bombPrefab;
    float span = 1.0f;
    float delta = 0;

    void Update()
    {
        this.delta += Time.deltaTime;
        if (this.delta > this.span)
        {
            this.delta = 0;
            /*
            Instantiale 메서드의 반환값으로 사과의 인스턴스를 받고,
            이 인스턴스의 X 좌표와 Z 좌표에 각각 -1, 0, 1 값을 무작위로 대입한다.

            Range의 메서드를  이용해 X, Z 값을 정한다.
             */
            GameObject item = Instantiate(applePrefab);
            float x = Random.Range(-1, 2);
            float z = Random.Range(-1, 2);
            item.transform.position = new Vector3(x, 4, z);
        }
    }
}
