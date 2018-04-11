using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowTrap : MonoBehaviour {
    public GameObject bearTrap;
    private TrapActive _trapActive;
    private GameObject _trapActivator;
    // Use this for initialization
    void Start () {
        _trapActive = GetComponent<TrapActive>();
        _trapActivator = GameObject.Find("TrapActivator");
	}
	
	// Update is called once per frame
	void Update () {
		if (_trapActive.activateTrap)
        {
            bearTrap.SetActive(true);
            _trapActivator.SetActive(false);
        }
	}
}
