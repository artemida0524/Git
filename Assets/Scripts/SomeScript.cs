using TMPro;
using UnityEngine;

public class SomeScript : MonoBehaviour
{
    [SerializeField] private int value;


    private void Update()
    {
        Vector3 newPosition = transform.position;
        newPosition += new Vector3(0, 0, value) * Time.deltaTime;
        transform.position = newPosition;
    }



    private void NewFunc()
    {
        Debug.Log("SomeFunc");
    }

}