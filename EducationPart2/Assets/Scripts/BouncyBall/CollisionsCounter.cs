using UnityEngine;
using UnityEngine.UI;

public class CollisionsCounter : MonoBehaviour
{
    [SerializeField]
    private Text _bounceCounterUI;

    [SerializeField]
    private Text _passCounterUI;

    private float _bounceCounter = 0f;
    private float _passCounter = 0f;

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.layer == 8)
        {
            if(_bounceCounterUI != null)
            {
                _bounceCounter++;
                _bounceCounterUI.text = _bounceCounter.ToString();
            }
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.layer == 9)
        {
            if (_passCounterUI != null)
            {
                _passCounter++;
                _passCounterUI.text = _passCounter.ToString();
            }
        }
    }
}
