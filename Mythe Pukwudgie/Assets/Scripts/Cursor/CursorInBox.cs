using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CursorInBox : MonoBehaviour {
	void Update () {
        CheckPosition();
    }
    void CheckPosition(){
        // X axis
        if (transform.position.x <= 118f){
            transform.position = new Vector3(118f, transform.position.y, transform.position.z);
        }
        else if (transform.position.x >= 152f){
            transform.position = new Vector3(152f, transform.position.y, transform.position.z);
        }
        // Y axis
        if (transform.position.y <= 10f){
            transform.position = new Vector3(transform.position.x, 10f, transform.position.z);
        }
        else if (transform.position.y >= 22f){
            transform.position = new Vector3(transform.position.x, 22f, transform.position.z);
        }
    }
}
