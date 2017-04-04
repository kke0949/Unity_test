using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ARMoveObject : MonoBehaviour {

    public float moveSpeed = 0.1f;
    public float turnSpeed = 100f;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");

        //transform.Translate (0f, 0f, h * moveSpeed * Time.deltaTime);

        //Move 
        this.transform.Translate(0f, 0f, v * moveSpeed * Time.deltaTime);

        //Turn
        this.transform.Rotate(0f, h * turnSpeed * Time.deltaTime, 0f);
    }
}
