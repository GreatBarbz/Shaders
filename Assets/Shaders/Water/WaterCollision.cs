using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;

public class WaterCollision : MonoBehaviour
{
    public Mesh mesh;
    Vector3[] vertices;
    public GameObject ball;
    public int v;
    public Material material;

// Use this for initialization
    void Start()
    {
        
    }


// Update is called once per frame
    void Update () 
    {
        mesh = GetComponent<MeshFilter>().sharedMesh;
        vertices = mesh.vertices;
        ball.transform.position = vertices[v];
        for (var i = 0; i < vertices.Length; i++)
        {
            
            //Debug.DrawLine(vertices[i], Vector3.up, Color.red);
        }

        mesh.RecalculateBounds();
    }
}
