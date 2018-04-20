using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Arrived : MonoBehaviour {
    private Waypoints _wp;
    private NewLocation _nl;

    private void Start()
    {
        _wp = this.GetComponent<Waypoints>();
        _nl = this.GetComponent<NewLocation>();
    }

    public void AtLocation()
    {
        _wp.LastPosition = _wp.NextPosition;
        _nl.NextLocation();

        _wp.StartTime = Time.time;
        _wp.Distance = Vector3.Distance(_wp.LastPosition, _wp.NextPosition);
    }
}
