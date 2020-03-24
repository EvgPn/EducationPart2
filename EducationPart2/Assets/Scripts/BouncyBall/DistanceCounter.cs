using UnityEngine;
using UnityEngine.UI;

public class DistanceCounter : MonoBehaviour
{
    [SerializeField]
    private GameObject _platform = null;
    [SerializeField]
    private GameObject _ball = null;
    [SerializeField]
    private float _distance = 0f;
    [SerializeField]
    private Text _distanceUI = null;

    private void Update()
    {
        _distance = _ball.transform.position.y - _platform.transform.position.y;
        _distanceUI.text = _distance.ToString();
    }
}
