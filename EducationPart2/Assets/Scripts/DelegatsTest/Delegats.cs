using UnityEngine;
using System;

public class Delegats : MonoBehaviour
{
    private Action<int> TestActionDelegate;
    private Func<int, bool> TestFuncDelegate;

    private void Start()
    {
        TestActionDelegate = (int num) => { Debug.Log("This is Action delegat" + num); };
        TestActionDelegate(1);

        TestFuncDelegate = (int num) => (num > 5);
        Debug.Log(TestFuncDelegate(6));
    }
}
