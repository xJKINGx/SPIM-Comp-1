using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using Unity.VisualScripting;
using UnityEditor.Callbacks;
using UnityEngine;
using UnityEngine.PlayerLoop;
using UnityEngine.UIElements;
using UnityEngine.Video;

public class PinballFlipper : MonoBehaviour
{
    [SerializeField] AnimationCurve animCurve;
    [Space]
    [SerializeField] bool FlipRotation = false;

    private Rigidbody rb;
    private Quaternion startRot;

    private float timer = 1;

    private void Awake() {
        rb = GetComponent<Rigidbody>();
        startRot = transform.rotation;
    }

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            timer = 0.0f;
        }    

        timer += Time.deltaTime; 
    }

    private void FixedUpdate() 
    {
        if (FlipRotation)
        {
            rb.MoveRotation(startRot * Quaternion.Euler(0,0,animCurve.Evaluate(timer) * -90f));
        }
        else
        {
            rb.MoveRotation(startRot * Quaternion.Euler(0,0,animCurve.Evaluate(timer) * 90f));
        }
    }
}
