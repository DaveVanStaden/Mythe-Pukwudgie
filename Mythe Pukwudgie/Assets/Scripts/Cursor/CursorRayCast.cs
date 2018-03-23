using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CursorRayCast : MonoBehaviour
{
    private Collider _coll;
    [SerializeField]
    private GameObject _block;
    private int _layerMask = 1 << 9;

    void Start()
    {
        _coll = GetComponent<Collider>();
    }

    void Update()
    {
        RaycastHit hit;
        Ray ray = new Ray(transform.position, _block.transform.position - transform.position);
        Debug.DrawRay(ray.origin, ray.direction * 100);
        if (Physics.Raycast(ray,out hit, float.MaxValue, _layerMask))
            Debug.Log("Hit something!");
    }
}