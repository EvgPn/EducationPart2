using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SphereCastScript : MonoBehaviour
{
    [SerializeField]
    private float _sphereCastRadius = 0.5f;
    private LineRenderer _laserLine;
    private float _sphereCastMaxDistance;

    private void Start()
    {
        _laserLine = GetComponent<LineRenderer>();
        _laserLine.SetPosition(0, transform.position);
        _laserLine.SetPosition(1, transform.position + (Vector3.right*6));
        _laserLine.enabled = true;
        _sphereCastMaxDistance = Vector3.Distance(transform.position, _laserLine.GetPosition(1));
    }

    private void Update()
    {
        RaycastHit hit;
        if(Physics.SphereCast(transform.position, _sphereCastRadius, Vector3.right, out hit, _sphereCastMaxDistance))
        {
            _laserLine.enabled = false;
            PlayerPrefs.SetString("target", "FRIENDLY CUBE");
        }
        else
        {
            _laserLine.enabled = true;
            PlayerPrefs.SetString("target", "NO TARGET");
        }        
    }
}
