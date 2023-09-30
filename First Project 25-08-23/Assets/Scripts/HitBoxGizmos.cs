using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class HitBoxGizmos : MonoBehaviour
{

    [Header("Collision Types")]
    [Space]
    
    [SerializeField] bool Cube = false;
    [SerializeField] bool WireCube = false;
    [SerializeField] bool Capsule = false;
    [SerializeField] bool Sphere = false;

    [SerializeField] bool IsVisible = true;
    Matrix4x4 GetGizmoMatrix()
    {
        Matrix4x4 rotationMatrix = Matrix4x4.TRS(transform.position, transform.rotation, transform.localScale);
        return rotationMatrix;
    }

    private void OnDrawGizmos() 
    {
        if (IsVisible)
        {
            Gizmos.matrix = GetGizmoMatrix();

            if (Cube)
            {
                Gizmos.DrawCube(new Vector3(0,0,0), new Vector3(1,1,1));
            } 

            if (WireCube)
            {
                Gizmos.DrawWireCube(new Vector3(0,0,0), new Vector3(1,1,1));
            }

            if (Capsule)
            {

            }

            if (Sphere)
            {

            }
        }
       
    }
}
