using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestScene1 : MonoBehaviour
{
    [SerializeField] private TestScene2 _someScript;
    private void Start()
    {
        TestScene2 scene =  Instantiate(_someScript);

        scene.gameObject.SetActive(false);
    }
}
