using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GravityController : MonoBehaviour {

    const float Gravity = 9.81f;    //중력 가속도
    public float gravityScale = 1.0f;   //중력의 적용상태
    
	void Start () {

	}
	
	void Update () {

        Vector3 vec = new Vector3();
        if (Application.isEditor)
        {
            vec.x = Input.GetAxis("Horizontal");
            vec.z = Input.GetAxis("Vertical");

            //높이 방향의 판정 : z키
            if (Input.GetKey("z"))
                vec.y = 1.0f;
            else
                vec.y = -1.0f;
        }
        else
        {
            //가속도 센서의 입력을 유니티 공간의 축에 매핑한다
            vec.x = Input.acceleration.x;
            vec.z = Input.acceleration.z;
            vec.y = Input.acceleration.y;

        }
        
        //판정된 방향 값을 계산해 위/아래로 떨어지게 설정
        Physics.gravity = Gravity * vec.normalized * gravityScale;
    }
}
