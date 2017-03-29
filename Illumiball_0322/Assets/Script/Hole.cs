using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hole : MonoBehaviour {

    bool fallIn;
    public string activeTag;    // 빨아들일 공을 태그로 지정

    // 공이 들어와 있는지를 반환!
    public bool IsFallIn()
    {
        return fallIn;
    }

    // 충돌 이벤트 처리
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == activeTag)
            fallIn = true;
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == activeTag)
            fallIn = false;
    }

    // 콜라이더끼리의 겹침
    private void OnTriggerStay(Collider other)
    {        
        Rigidbody r = other.gameObject.GetComponent<Rigidbody>();

        //공이 어느 방향에 있는지를 계산
        Vector3 direction = transform.position - other.gameObject.transform.position;
        direction.Normalize();
        
        // 태그에 따라 공의 힘을 더한다!
        if(other.gameObject.tag == activeTag)
        {
            // 중심에서 공을 멈추기 위해 천천히 감속시킴
            r.velocity *= 0.9f;
            r.AddForce(direction * r.mass * 20.0f);
        }
        else
        {
            r.AddForce(-direction * r.mass * 80.0f);
        }
    }
}
