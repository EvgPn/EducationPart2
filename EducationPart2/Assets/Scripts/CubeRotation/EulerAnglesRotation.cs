using UnityEngine;

public class EulerAnglesRotation : MonoBehaviour
{
    [SerializeField]
    private float _rpm = 60f;

    private void FixedUpdate()
    {
        transform.eulerAngles += Vector3.up * Time.deltaTime * (_rpm * 6f);
    }
}
