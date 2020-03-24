using UnityEngine;

public class RayViewer : MonoBehaviour
{
    [SerializeField]
    private GameObject _cube2 = null;
    private float _distance;

    private void Start()
    {
        _distance = Vector3.Distance(transform.position, _cube2.transform.position);
    }

    private void Update()
    {
        Debug.DrawRay(transform.position, Vector3.right * _distance, Color.yellow);        
    }
}
