using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrackingScript : MonoBehaviour
{
    [SerializeField] GameObject target; // In this case it will be the player

    // Update is called once per frame
    void Update()
    {
       float z = target.transform.position.z - 10.0f; // Changing the z value to get the offset so the camera isn't inside the player
       Vector3 targetPos = new Vector3(target.transform.position.x, target.transform.position.y, z); // Creating a vector of the values
       transform.SetPositionAndRotation(targetPos, target.transform.rotation); // We set the position and rotation of the camera to the player, with the offset
    }
}
