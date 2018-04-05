using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Moving : MonoBehaviour {
    private Waypoints _wp;
    private Arrived _ariv;

    private void Start()
    {
        _wp = this.GetComponent<Waypoints>();
        _ariv = this.GetComponent<Arrived>();
    }

    public void Move()
    {
        if (transform.position.x == _wp.NextPosition.x && transform.position.z == _wp.NextPosition.z)
           _ariv.AtLocation();

        float coveredDistance = (Time.time - _wp.StartTime) * _wp.MovementSpeed;
        float journey = coveredDistance / _wp.Distance;
        print(journey);
        if (!float.IsNaN(journey))
            this.transform.position = Vector3.Lerp(_wp.LastPosition, _wp.NextPosition, journey);
    }
}
