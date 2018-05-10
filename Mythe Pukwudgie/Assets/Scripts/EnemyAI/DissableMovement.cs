using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DissableMovement : MonoBehaviour {
    private TrapChecker _trapChecker;
    [SerializeField]private GameObject _player;
    private Waypoints _wp;
    private Rigidbody _rb;
    // Use this for initialization
    void Start () {
        _trapChecker = GetComponent<TrapChecker>();
        _wp = _player.GetComponent<Waypoints>();
        gameObject.SetActive(false);
    }
	
	// Update is called once per frame
	void Update () {
    }
    private void OnTriggerEnter(Collider other)
    {
        if (_trapChecker.activate)
        {
            _wp.enabled = false;
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
            Debug.Log(_wp.enabled);
        }
        
    }
}
