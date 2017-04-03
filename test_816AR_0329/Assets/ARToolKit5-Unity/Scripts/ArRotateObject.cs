using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArRotateObject : MonoBehaviour {
    public float moveSpeed = 1000000000000001f;
    public float turnSpeed = 1f;

    void Start() {

    }

    void Update() {
        moveObject();
    }

    void moveObject() {
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");

        //transform.Translate (0f, 0f, h * moveSpeed * Time.deltaTime);

        //Move 
        this.transform.Translate(0f, 0f, v * moveSpeed * Time.deltaTime);

        //Turn
        this.transform.Rotate(0f, h * turnSpeed * Time.deltaTime, 0f);
    }
}
