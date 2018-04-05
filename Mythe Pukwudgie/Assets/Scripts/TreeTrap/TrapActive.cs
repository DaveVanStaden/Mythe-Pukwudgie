using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrapActive : MonoBehaviour {
    public bool activateTrap = false;
    private void OnTriggerStay(Collider other){
        Debug.Log(activateTrap + " " + other.tag);
        if (other.tag == "TrapActivator"){
            activateTrap = true;
        } else{
            activateTrap = false;
        }
    }
}
