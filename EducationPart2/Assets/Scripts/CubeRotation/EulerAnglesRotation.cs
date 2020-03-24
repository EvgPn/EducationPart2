using UnityEngine;

public class EulerAnglesRotation : MonoBehaviour
{
    [SerializeField]
    private float _rpm = 60f;
    private float _fullRotationAngle = 360f;
    private float _secondsInMinute = 60f;

    private void Update()
    {
        transform.Rotate(new Vector3(1,1,0), (_fullRotationAngle / _secondsInMinute) * _rpm * Time.deltaTime);       
    }
    
}
