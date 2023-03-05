using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; // for using UI

public class GameDirector : MonoBehaviour
{
    // 게임안의 오브젝트를 담을 변수를 생성해준다.
    GameObject car;
    GameObject flag;
    GameObject distance;

    void Start()
    {
        this.car = GameObject.Find("car");
        this.flag = GameObject.Find("flag");
        this.distance = GameObject.Find("Distance");
    }

    void Update()
    {
        float length = this.flag.transform.position.x - this.car.transform.position.x;

        if (length >= 0)
        {
            this.distance.GetComponent<Text>().text = "목표 지점까지 " + length.ToString("F2") + "m";
        }
        else
        {
            this.distance.GetComponent<Text>().text = "게임 오버!!";
        }
    }

}
