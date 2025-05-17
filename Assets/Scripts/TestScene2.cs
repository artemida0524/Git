using UnityEngine;

public class TestScene2 : MonoBehaviour
{
    private void Awake()
    {
        Debug.Log("Awake");
    }

    private void Start()
    {

        Debug.Log("Start");
    }


    private void OnEnable()
    {

        Debug.Log("OnEnable");
    }

    private void OnDisable()
    {

        Debug.Log("OnDisable");
    }

}