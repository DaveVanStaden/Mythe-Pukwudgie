using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CursorMovement : MonoBehaviour {
    private float _x;
    private float _y;
    public float speed = 5;
    public float rotationSpeed = 5;

	void Update () {
        Movement();
    }
    void Movement(){
        float translation = Input.GetAxis("Vertical") * speed;
        float rotation = Input.GetAxis("Horizontal") * rotationSpeed;
        translation *= speed * Time.deltaTime;
        rotation *= speed * Time.deltaTime;
        transform.Translate(rotation, translation, 0);
    }
}
