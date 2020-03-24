using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScriptWithPlayerPrefs : MonoBehaviour
{
    [SerializeField]
    private Text _targetFild = null;
    void Update()
    {
        _targetFild.text = PlayerPrefs.GetString("target");
    }
}
