using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CursorMovement3 : MonoBehaviour {
    private float _x;
    private float _y;
    public float speed = 5;
    private float _horizontalInput;
    private float vertical;
    private float horizontal;
    private string stickY;
    private string stickX;

    private void Start()
    {
        if (stickY == null)
            stickY = Controller.LeftStickYP4;
        if (stickX == null)
            stickX = Controller.LeftStickXP4; 
    }
    void Update () {
        vertical = Input.GetAxis(stickY) * speed;
        horizontal = Input.GetAxis(stickX) * speed;
    }
    void FixedUpdate(){
        vertical *= speed * Time.deltaTime;
        horizontal *= speed * Time.deltaTime;
        transform.Translate(-horizontal, -vertical, 0);
    }
}
