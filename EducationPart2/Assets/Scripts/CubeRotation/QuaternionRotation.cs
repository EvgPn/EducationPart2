using UnityEngine;

public class QuaternionRotation : MonoBehaviour
{
    [SerializeField]
    private float _rpm = 60f;
    [SerializeField]
    private GameObject _centerOfRotation = null;
    private Vector3 _distanceToTheCenterOfRotation;
    
    private void Start()
    {        
        _distanceToTheCenterOfRotation = transform.position - _centerOfRotation.transform.position;
    }
    private void Update()
    {
        _distanceToTheCenterOfRotation = Quaternion.AngleAxis(Time.deltaTime * _rpm * 6f, Vector3.up) * _distanceToTheCenterOfRotation;
        transform.position = _centerOfRotation.transform.position + _distanceToTheCenterOfRotation; 
    }
}
