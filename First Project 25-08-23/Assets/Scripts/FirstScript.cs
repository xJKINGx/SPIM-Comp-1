using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FirstScript : MonoBehaviour
{

    float xVal;
    [SerializeField] float yVal;
    [SerializeField] float zVal;
    [SerializeField] GameObject obj;
    [SerializeField] float speed;

    bool increase = true;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Hello World!");
        speed = 5;
        // After 0 seconds, call "ChangeSpeed" and call it again repeatedly every 2 seconds
        //InvokeRepeating("ChangeSpeed", 0.0f, 2f);
    }


    // Update is called once per frame
    void Update()
    {
        xVal = Input.GetAxis("Horizontal") * Time.deltaTime * speed;
        zVal = Input.GetAxis("Vertical") * Time.deltaTime * speed;
        transform.Translate(xVal, yVal, zVal);
    }

    // This changes the speed of the player, it can increase and revert the speed of the player
    void ChangeSpeed()
    {
        if (increase)
        {
            speed += 10;
            increase = false;
        }
        else
        {
            speed -= 10;
            increase = true;
        }
    }
}
