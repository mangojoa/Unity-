using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; // LoadScene을 사용하는데 필요합니다
public class ClearDirector : MonoBehaviour
{
    void Update()
    {
        // 마우스가 클릭된 것을 감지했으면 SceneManager 클래스의
        // LoadScene 메서드를 사용해 게임 씬으로 전환합니다
        // LoadScene은 매개변수로 받은 씬 이름의 씬을 로드하는 메서드
        if (Input.GetMouseButtonDown(0))
            // 여기서 게임 씬으로 전환해야 하므로 매개변수의 씬 이름을 GameScene으로 입력
            SceneManager.LoadScene("Scenes/SampleScene");
    }
}
