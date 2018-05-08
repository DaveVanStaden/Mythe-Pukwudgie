using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DissableMovement : MonoBehaviour {
    private TrapChecker _trapChecker;
    [SerializeField]private GameObject _player;
    private Waypoints _waypoints;
    private Rigidbody _rb;
    // Use this for initialization
    void Start () {
        _trapChecker = GetComponent<TrapChecker>();
        _waypoints = _player.GetComponent<Waypoints>();
        gameObject.SetActive(false);
    }
	
	// Update is called once per frame
	void Update () {

    }
    private void OnTriggerEnter(Collider other)
    {
        if (_trapChecker.activate)
        {
            _waypoints.enabled = false;
            Debug.Log(_waypoints.enabled);
        }
    }
}
