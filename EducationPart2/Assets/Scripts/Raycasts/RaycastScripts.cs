using UnityEngine;

public class RaycastScripts : MonoBehaviour
{
    private float _raycastRange = 50f;                                               
    private LineRenderer _laserLine;                                        

    void Start()
    {
        _laserLine = GetComponent<LineRenderer>();
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            RaycastHit hit;
            _laserLine.SetPosition(0, transform.position);
            if (Physics.Raycast(transform.position, Vector3.right, out hit, _raycastRange))
            {
                _laserLine.SetPosition(1, hit.point);                
            }
            else
            {
                _laserLine.SetPosition(1, transform.position + (transform.transform.forward * _raycastRange));
            }
            _laserLine.enabled = true;
        }
        if(Input.GetMouseButtonUp(0))
        {
            _laserLine.enabled = false;
        }
    }
}

