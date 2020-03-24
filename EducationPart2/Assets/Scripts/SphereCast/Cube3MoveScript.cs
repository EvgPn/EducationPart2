using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube3MoveScript : MonoBehaviour
{
    [SerializeField]
    private float _moveSpeed = 1f;
    private float _minZPosition = -8f;
    private float _maxZPosition = -4f;
    private Vector3 _moveDirection = new Vector3(0, 0, -1); 
    void Update()
    {
        transform.position += _moveDirection * _moveSpeed * Time.deltaTime;
        if(transform.position.z <= _minZPosition)
        {
            _moveDirection = new Vector3(0, 0, 1);
        }
        if(transform.position.z >= _maxZPosition)
        {
            _moveDirection = new Vector3(0, 0, -1);
        }
    }
}
