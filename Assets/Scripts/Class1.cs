using System;
using UnityEngine;


public class Class1 : MonoBehaviour
{

    [SerializeField] private int value;

    private void Update()
    {
        if (value == 0)
        {
            Debug.Log("New Color");
            GetComponent<MeshRenderer>().material.color = Color.red;
            Debug.Log("efwefewfwef");
        }
    }

}
