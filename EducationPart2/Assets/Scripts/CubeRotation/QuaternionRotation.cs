using UnityEngine;

public class QuaternionRotation : MonoBehaviour
{
    [SerializeField]
    private float _rpm = 60f;
    [SerializeField]
    private Transform _centerOfRotation;
    private Vector3 _v;
    private void Start()
    {
        _v = transform.position - _centerOfRotation.position;
    }
    private void FixedUpdate()
    {
        _v = Quaternion.AngleAxis(Time.deltaTime * _rpm * 6f, Vector3.up) * _v;
        transform.position = _centerOfRotation.position + _v; 
    }
}
