using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovePlayer : MonoBehaviour {
    private Rigidbody myRigidbody;
    private float mySpeed;
    private Vector3 forward;
    private Vector3 back;
    private Vector3 right;
    private Vector3 left;
    
    void Start() {
        myRigidbody = GetComponent<Rigidbody>();
        mySpeed = 3.5f;
        forward = new Vector3(0, 0, 1);
        back = new Vector3(0, 0, -1);
        right = new Vector3(1, 0, 0);
        left = new Vector3(-1, 0, 0);
    }

    void Update() {
        if (Input.GetKey(KeyCode.UpArrow)) {
            myRigidbody.velocity = forward * mySpeed;
        } else if (Input.GetKey(KeyCode.DownArrow)) {
            myRigidbody.velocity = back * mySpeed;
        } else if (Input.GetKey(KeyCode.RightArrow)) {
            myRigidbody.velocity = right * mySpeed;
        } else if (Input.GetKey(KeyCode.LeftArrow)) {
            myRigidbody.velocity = left * mySpeed;
        }
    }
}
