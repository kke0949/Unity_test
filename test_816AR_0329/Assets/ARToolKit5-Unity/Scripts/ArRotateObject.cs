using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArRotateObject : MonoBehaviour {

    public float speed = 0.5f;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        //transform.Rotate(0, Time.deltaTime * 50, 0);
        moveObject();
   }
    void moveObject()
    {
        float keyHorizontal = Input.GetAxis("Horizontal");
        float keyVertical = Input.GetAxis("Vertical");

        transform.Translate(Vector3.right * speed * Time.smoothDeltaTime * keyHorizontal, Space.World);
        transform.Translate(Vector3.up * speed * Time.smoothDeltaTime * keyVertical, Space.World);
    }
}
