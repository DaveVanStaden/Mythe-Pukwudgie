using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DragManager : MonoBehaviour
{

	private bool _isDragged;
    private int _hand = 0;
    private float _pickUpCooldown = 3;
    [SerializeField]
    private Material _material;
	private Material _defaultMaterial;


    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
		//Debug.Log (_hand);
		Debug.Log(_hand);
		Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
		RaycastHit hit;
		if (Physics.Raycast(ray, out hit))
		{
			if (hit.collider.gameObject.tag == "Drag" && Input.GetKeyDown("e"))
			{
				Rigidbody _rb = hit.collider.gameObject.GetComponent<Rigidbody>();
				_hand = _hand + 1;
				_isDragged = true;
				if (_hand == 1 && _isDragged == true) {
					_pickUpCooldown -= Time.deltaTime;
					hit.collider.gameObject.transform.parent = this.transform;
					hit.collider.gameObject.transform.position = transform.position;
					_defaultMaterial = hit.collider.gameObject.GetComponent<Renderer> ().material;
					hit.collider.gameObject.GetComponent<Renderer> ().material = _material;
                    Physics.IgnoreCollision(hit.collider, this.GetComponent<Collider>(), true);
					//hit.collider.gameObject.GetComponent<Renderer> ().material.color.a = ;
					//hit.collider.gameObject.tag("Drag").GetComponent<Renderer>().material = _material;
					_rb.useGravity = false;
					if (_hand == 1 && Input.GetKeyDown ("e") && _pickUpCooldown < 0 && _isDragged == true) {
						_hand = 1 - 1;
						_isDragged = false;
					}
				} else if (_hand != 1) {
					hit.collider.gameObject.GetComponent<Renderer> ().material = _defaultMaterial;
                    Physics.IgnoreCollision(hit.collider, this.GetComponent<Collider>(), false);
                    _rb.useGravity = true;
					hit.collider.gameObject.transform.position = hit.collider.gameObject.transform.position;
					hit.collider.gameObject.transform.parent = null;
					_isDragged = false;
				} if (_hand == 1 && Input.GetKeyDown ("e") && _isDragged == true || _hand > 1) {
					_hand = 0 - 1;
					_isDragged = false;
				}
			}



		}
    }

}

    

   
        


    /*private void OnCollisionEnter(Collision collision){
        if(collision.gameObject.tag == "Drag")
        {
            Debug.Log("Collide");
            if (Input.GetKey("e"))
            {
                Debug.Log("it works");
                collision.transform.position = transform.position;
                collision.gameObject.transform.parent = this.transform;
                hand = hand + 1;
                if(hand == 1)
                {
                    Debug.Log(PickUpCooldown);
                    transform.position = collision.gameObject.transform.position;
                    if (hand == 1 && Input.GetKey("e") && PickUpCooldown >= 5f)
                    {
                        hand = hand - 1;
                        collision.gameObject.transform.parent = null;
                    }


                }


            }

        }
        */



