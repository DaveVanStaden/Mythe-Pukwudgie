using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewLocation : MonoBehaviour {
    private Waypoints _wp;

    private void Start()
    {
        _wp = this.GetComponent<Waypoints>();
    }

    public void NextLocation()
    {
        if (_wp.CurrentPointIndex == _wp.PointIndex)
            _wp.PointIndex++;
        Debug.Log(_wp.PointIndex);
        _wp.CurrentPointIndex = _wp.PointIndex;
        _wp.NextPosition = new Vector3(_wp.Points[_wp.PointIndex].transform.position.x, 0, _wp.Points[_wp.PointIndex].transform.position.z);
    }
}
