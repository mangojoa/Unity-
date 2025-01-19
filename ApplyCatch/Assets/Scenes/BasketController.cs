using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasketController : MonoBehaviour
{
    /* 사과와 폭탄을 받았을 때 다른 효과음을 내야 하므로 Audioclip 변수를 2개 선언
     * 
     * 이후, 효과음을 내는 시점이 바구니와 아이템이 충돌했을 때 이므로 OnTriggetEnter에 효과음을 재생하는 스크립트 작성
     * 
     * 무엇이 충돌했는지는 상대의 Tag를 보고 판단하도록!
     * 
     */
    public AudioClip appleSE;
    public AudioClip bombSE;
    AudioSource aud;

    private void Start()
    {
        this.aud = GetComponent<AudioSource>();
    }



    private void OnTriggerEnter(Collider other)
    {
        // 프로젝트에 tag시스템을 이용하여
        // 각 오프젝트에 tag를 적용 후, 이와 접촉시 Log를 출력하도록 작성
        if (other.gameObject.tag == "Apple")
        {
            Debug.Log("Tag = Apple");
            this.aud.PlayOneShot(this.appleSE);
        }
        else
        {
            Debug.Log("Tag = Bomb");
            this.aud.PlayOneShot(this.bombSE);
        }
        Destroy(other.gameObject);
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            /* 탭된 좌표를 바탕으로 바구니를 이동시키는 좌표를 계산함
            input.mousePosition 은 스크린 좌표이므로 그대로 사용할 수 없기에

            여기서는 스크린 좌표를 월드 좌표로 변환해 사용할 수 있도록
            ScreenPointToRay 메서드를 사용해 카메라 좌표에서 게임 화면 안쪽 방향으로 향해 나가는 광선(Ray)를 계산

            이 광선(Ray)은 콜라이더와 충돌한 것을 감지할 수 있고 Physic. Raycast 메서드를 사용해
            광선이 stage 오브젝트에 닿았는지를 판별합니다.

            Physics.Raycast 의 hit 매개변수 앞에 out 키워드?
            'out에 계속 메서드 내 값을 채워 변수로 반환해 주세요!' 라는 의미 입니다. 이때 RayCast 매서드 안에서
            광선이 stage와 충돌한 좌표를 hit.point 변수에 채워 반환합니다.

            RoundToInt 메서드를 사용해 반올림하고 바구니 좌표에 대입한다.
            */
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

            RaycastHit hit;

            if (Physics.Raycast(ray, out hit, Mathf.Infinity))
            {
                float x = Mathf.RoundToInt(hit.point.x);
                float z = Mathf.RoundToInt(hit.point.z);

                transform.position = new Vector3(x, 0, z);
            }
        }
    }
}
