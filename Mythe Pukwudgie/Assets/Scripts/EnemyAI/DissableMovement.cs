using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DissableMovement : MonoBehaviour {
    private TrapChecker _trapChecker;
    private GameObject _trap;
    private Waypoints _waypoints;
    public bool WalkAnim = true;
    // Use this for initialization
    void Start () {
        _trapChecker = GameObject.Find("Trap").GetComponent<TrapChecker>();
        _trap = GameObject.Find("Trap");
        _trap.SetActive(false);
        _waypoints = GetComponent<Waypoints>();
    }
	
	// Update is called once per frame
	void Update () {
        if (_trapChecker.activate)
        {
            _waypoints.enabled = false;
            Debug.Log(_waypoints.enabled);
            WalkAnim = false;
        } else
        {
            WalkAnim = true;
        }
    }
}
