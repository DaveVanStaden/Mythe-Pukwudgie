using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParticleTrap : MonoBehaviour {
    private TrapChecker _trapChecker;
    private Waypoints _waypoints;
    private ParticleSystem _particleSystem;
    // Use this for initialization
    void Start()
    {
        _trapChecker = GetComponent<TrapChecker>();
        _particleSystem = GetComponent<ParticleSystem>();
        _particleSystem.Stop();
    }

    // Update is called once per frame
    void Update()
    {
        if (_trapChecker.activate)
        {
            _particleSystem.Play();
        }
    }
}
