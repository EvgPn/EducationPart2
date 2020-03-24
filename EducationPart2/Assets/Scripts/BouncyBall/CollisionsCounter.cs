using UnityEngine;

public class CollisionsCounter : MonoBehaviour
{
    [SerializeField]
    private LayerMask _platformLayer = new LayerMask();
    [SerializeField]
    private LayerMask _circleLayer = new LayerMask();

    private int _bounceCounter = 0;
    private int _passCounter = 0;

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.layer == _platformLayer)
        {
            _bounceCounter++;
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.layer == _circleLayer)
        {
            _passCounter++;
        }
    }
}
