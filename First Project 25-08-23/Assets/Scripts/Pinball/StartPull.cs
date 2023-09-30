using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartPull : MonoBehaviour
{
    private Rigidbody rb;
    [SerializeField] GameObject ball;
    Rigidbody ballrb;
    Vector3 startPos;
    void Awake()
    {
        startPos = transform.position;
        rb = GetComponent<Rigidbody>();
        ballrb = ball.GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.DownArrow) && transform.position.y > -9.0f)
        {
            transform.Translate(new Vector3(0, -1, 0) * Time.deltaTime);
        }
        else if (transform.position.y < -7.0f && !Input.GetKey(KeyCode.DownArrow))
        {
            ballrb.AddForce(new Vector3(0, 1, 0) * (Mathf.Abs(transform.position.y - startPos.y)), ForceMode.Impulse);

            if (transform.position.y < -2.0f)
            {
                transform.Translate(new Vector3(0, 4, 0) * Time.deltaTime);
            }
            else
            {
                transform.position = startPos;
            }
        }
    }
}
