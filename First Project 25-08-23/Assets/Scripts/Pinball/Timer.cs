using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Timer : MonoBehaviour
{

    public bool gameOver = false;
    TextMeshProUGUI text;
    TimeSpan ts;

    float time = 0.0f;

    void Awake() {
        text = GetComponent<TextMeshProUGUI>();    
    }
    // Update is called once per frame
    void Update()
    {
        if (!gameOver)
        {
            time += Time.deltaTime;
            ts = TimeSpan.FromSeconds(time);
            text.text = "Time: " + ts.ToString("hh\\:mm\\:ss");
        }
        else
        {
            text.text = "Time: " + ts.ToString("hh\\:mm\\:ss") + " - GAME OVER";
        }
    }
}
