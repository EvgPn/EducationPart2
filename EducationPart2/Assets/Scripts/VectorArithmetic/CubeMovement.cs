using UnityEngine;

public class CubeMovement : MonoBehaviour
{
    [SerializeField]
    private Vector3 _moveDirection = new Vector3(0, 0, 0); //e.g. (1,0,0)
    private float _moveSpeed = 2f;

    private void Update()
    {
        transform.position += _moveDirection * _moveSpeed * Time.deltaTime;
    }
}
