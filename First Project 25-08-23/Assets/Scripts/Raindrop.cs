using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Raindrop : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        float xPos = Random.Range(-8.0f, 8.0f);   
        float zPos = Random.Range(-8.0f, 8.0f);  
        float yPos = 20.0f;

        transform.Translate(xPos, yPos, zPos);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
