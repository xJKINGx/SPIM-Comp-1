using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class CollisionScript : MonoBehaviour
{
    void OnCollisionEnter(Collision other) 
    {
        Debug.LogWarning($"Collided with: {other.gameObject.name} holy shit this is insane!");
        
    }

    void OnTriggerEnter(Collider other) 
    {
        Debug.LogWarning($"Triggered with: {other.gameObject.name} holy shit this is insane!");
    }
}
