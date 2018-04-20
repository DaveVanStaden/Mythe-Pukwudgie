using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DragManager : MonoBehaviour
{

    private Camera _camera;
    private GameObject _dragObject;


    private int _hand = 0;
    private float PickUpCooldown = 3;
    [SerializeField]
    private Material _material;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
		Debug.Log (_hand);
		Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
		RaycastHit hit;
		if (Physics.Raycast(ray, out hit))
		{
			if (hit.collider.gameObject.tag == "Drag" && Input.GetKeyDown("e"))
			{
				Rigidbody _rb = hit.collider.gameObject.GetComponent<Rigidbody>();
				_hand = _hand + 1;
				if (_hand == 1) {
					PickUpCooldown -= Time.deltaTime;
					hit.collider.gameObject.transform.parent = this.transform;
					hit.collider.gameObject.transform.position = transform.position;
					_rb.useGravity = false;
					if (_hand == 1 && Input.GetKeyDown ("e") && PickUpCooldown < 0) {
						_hand = _hand - 1;
					}
				} else if (_hand != 1) {
					_rb.useGravity = true;
					_material = hit.collider.gameObject.GetComponent<Renderer> ().material;
					hit.collider.gameObject.transform.position = hit.collider.gameObject.transform.position;
					hit.collider.gameObject.transform.parent = null;
				} else if (_hand == 1 && Input.GetKeyDown ("e")) {
					_hand = _hand + 0;
				
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



