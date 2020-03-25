using UnityEngine;
using UnityEngine.UI;

public class BallEventController : MonoBehaviour
{
    [SerializeField]
    private GameObject _bounceCounterGO = null;
    [SerializeField]
    private GameObject _passCounterGO = null;

    private static Text _bounceCounter;
    private static Text _passCounter;

    private void Start()
    {
        _bounceCounter = _bounceCounterGO.GetComponent<Text>();
        _passCounter = _passCounterGO.GetComponent<Text>();
    }
    public static void BounceCounterUI(int amount)
    {
        _bounceCounter.text = amount.ToString();
    }
    public static void PassCounterUI(int amount)
    {
        _passCounter.text = amount.ToString();
    }
}
