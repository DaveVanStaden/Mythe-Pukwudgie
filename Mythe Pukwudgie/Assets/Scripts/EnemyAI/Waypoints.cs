using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Waypoints : MonoBehaviour {
    [SerializeField]private GameObject[] _points;
    private Vector3 _nextPosition;
    private Vector3 _lastPosition;
    private int _pointIndex;
    private int _currentPointIndex;
    private float _movementSpeed;
    private float _startTime;
    private float _distance;

    void Start ()
    {
        _pointIndex = Random.Range(0, _points.Length);
        _nextPosition = new Vector3 (_points[_pointIndex].transform.position.x, 0, _points[_pointIndex].transform.position.z);
        _lastPosition = this.transform.position;
        _movementSpeed = 1;
        _startTime = Time.time;
        _distance = Vector3.Distance(_lastPosition, _nextPosition);
    }
	
	void Update ()
    {
        if (this.transform.position.x == _nextPosition.x && this.transform.position.z == _nextPosition.z)
            Arrived();
        
        float coveredDistance = (Time.time - _startTime) * _movementSpeed;
        float journey = coveredDistance / _distance;
        print(journey);
        if(!float.IsNaN(journey))
            this.transform.position = Vector3.Lerp(_lastPosition, _nextPosition, journey);
	}

    void NewWaypoint()
    {
        if(_currentPointIndex == _pointIndex)
            _pointIndex = Random.Range(0, _points.Length);

        _currentPointIndex = _pointIndex;
        _nextPosition = new Vector3(_points[_pointIndex].transform.position.x, 0, _points[_pointIndex].transform.position.z);
    }

    void Arrived()
    {
        _lastPosition = _nextPosition;
        NewWaypoint();

        _startTime = Time.time;
        _distance = Vector3.Distance(_lastPosition, _nextPosition);
    }
}
