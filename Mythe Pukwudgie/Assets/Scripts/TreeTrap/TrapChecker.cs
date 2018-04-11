using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrapChecker : MonoBehaviour {
    private TrapActive _activateTrap;
    public bool activate = false;
    private void Start()
    {
        _activateTrap = GetComponent<TrapActive>();
    }

    private void OnTriggerEnter(Collider collision){
        print(collision.gameObject.name);
        if (collision.gameObject.tag == "Player") {
            Debug.Log(activate);
            activate = true;
        }  
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            Debug.Log("has no collision");
            activate = false;
        }
    }
    private void Update()
    {
        print(activate);
    }
}
