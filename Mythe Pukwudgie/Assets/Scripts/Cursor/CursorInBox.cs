using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CursorInBox : MonoBehaviour {
	void Update () {
        CheckPosition();
    }
    void CheckPosition(){
        // X axis
        if (transform.position.x <= -10f){
            transform.position = new Vector3(-10f, transform.position.y, transform.position.z);
        }
        else if (transform.position.x >= 10f){
            transform.position = new Vector3(10f, transform.position.y, transform.position.z);
        }
        // Y axis
        if (transform.position.y <= -5f){
            transform.position = new Vector3(transform.position.x, -5f, transform.position.z);
        }
        else if (transform.position.y >= 5f){
            transform.position = new Vector3(transform.position.x, 5f, transform.position.z);
        }
    }
}
