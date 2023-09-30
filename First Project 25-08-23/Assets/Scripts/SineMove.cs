using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SineMove : MonoBehaviour
{
    float x = 0; // The value we pass into the sin function.
    float yVal;

    // Update is called once per frame
    void Update()
    {
        yVal = Mathf.Sin(x) / 90;
        transform.Translate(0.0f, yVal, 0.0f);
        x += 0.01f;
    }
}
