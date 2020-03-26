using UnityEngine;

public class CollisionsCounter : MonoBehaviour
{    
    private int _bounceCounter = 0;
    private int _passCounter = 0;

    public delegate void BounceCounterCallback(int amount);
    public static event BounceCounterCallback IncreaseBounces;

    public delegate void PassesCounterCallback(int amount);
    public static event PassesCounterCallback IncreasePasses;
    
    private void OnCollisionEnter(Collision collision)
    {
        if (LayerToName(collision.gameObject.layer) == "Platform")
        {
            _bounceCounter++;
            IncreaseBounces?.Invoke(_bounceCounter);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (LayerToName(other.gameObject.layer) == "Circle")
        {
            _passCounter++;
            IncreasePasses?.Invoke(_passCounter);
        }
    }

    private string LayerToName(LayerMask layer)
    {
        return LayerMask.LayerToName(layer);
    }
}
