using Unity.VisualScripting;
using UnityEngine;
using static UnityEditor.Progress;

public class MoveHole : MonoBehaviour
{
    [SerializeField] private MeshFilter meshFilter;
    [SerializeField] private Transform point;
    [SerializeField] private MeshCollider meshCollider;

    private Vector3[] vertices;
    private Vector3[] offsets;

    private void Start()
    {
        meshFilter.mesh = Instantiate(meshFilter.sharedMesh);
        vertices = meshFilter.mesh.vertices;
        offsets = new Vector3[vertices.Length];

        for (var i = 0; i < vertices.Length; i++)
        {
            if (Vector3.Distance(point.position, vertices[i]) < 3)
            {
                offsets[i] = vertices[i] - point.position;
            }
        }
    }

    private void Update()
    {

        Vector3 localPoint = meshFilter.transform.InverseTransformPoint(point.position);


        Bounds bounds = meshFilter.mesh.bounds;

        for (var i = 0; i < vertices.Length; i++)
        {
            if (offsets[i] != Vector3.zero)
            {
                //some changes
                //some changes
                //some changes
                //some changes
                //some changes
                //some changes
                Vector3 newPos = localPoint + offsets[i];

                if (bounds.Contains(newPos))
                {
                    //some changes
                    //some changes

                    //some changes
                    //some changes
                    vertices[i] = newPos;
                }
                else
                {
                    break;
                }
            }
        }





        foreach (var item in vertices)
        {
            if (!bounds.Contains(item))
            {
                Debug.Log("fsdfsdfsdfsd");
            }
        }

        meshFilter.mesh.vertices = vertices;
        meshFilter.mesh.RecalculateBounds();
        meshFilter.mesh.RecalculateNormals();
        meshFilter.mesh.RecalculateTangents();

        meshCollider.sharedMesh = null;
        meshCollider.sharedMesh = meshFilter.mesh;

    }
}
