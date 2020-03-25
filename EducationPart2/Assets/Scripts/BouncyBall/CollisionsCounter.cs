using UnityEngine;

public class CollisionsCounter : MonoBehaviour
{    
    private int _bounceCounter = 0;
    private int _passCounter = 0;

    public delegate void OnBounceAmountReceived(int amount);
    public event OnBounceAmountReceived OnBouncingCount;

    public delegate void OnPassesAmountReceived(int amount);
    public event OnPassesAmountReceived OnPassesCount;

    private void Start()
    { 
        OnBouncingCount += BallEventController.BounceCounterUI;
        OnPassesCount += BallEventController.PassCounterUI;
    }
    private void OnCollisionEnter(Collision collision)
    {
        string layerName = LayerMask.LayerToName(collision.gameObject.layer);
        if (layerName == "Platform")
        {
            _bounceCounter++;
            OnBouncingCount(_bounceCounter);
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        string layerName = LayerMask.LayerToName(other.gameObject.layer);
        if (layerName == "Circle")
        {
            _passCounter++;
            OnPassesCount(_passCounter);
        }
    }
}
