using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LockRotation : MonoBehaviour {
    public GameObject Player;
    private Vector3 offset;

    void Start() {
        offset = new Vector3(0f, 1f, 0f);
    }
    
    void Update() {
        transform.position = Player.transform.position + offset;
    }
}
