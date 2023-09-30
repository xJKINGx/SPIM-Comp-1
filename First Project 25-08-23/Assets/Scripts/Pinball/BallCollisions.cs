using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class BallCollisions : MonoBehaviour
{
    int score = 0;
    TextMeshProUGUI scoreText;
    [SerializeField] Canvas UIReference;
    [SerializeField] GameObject timerObjectRef;
    [SerializeField] GameObject ClosingWall;
    
    Rigidbody rb;

    void Awake() 
    {
        rb = GetComponent<Rigidbody>();    
    }

    private void Start() 
    {
        scoreText = UIReference.GetComponentInChildren<TextMeshProUGUI>();
    }

    private void Update() 
    {
        if (scoreText != null)
        {
            scoreText.text = "Score: " + score + " points";
        }
        else
        {
            print("No TMP reference in BallCollisions.cs");
        }
    }

    private void OnTriggerEnter(Collider other) {
        if (other.gameObject.CompareTag("Pinball end hitbox"))
        {
            Debug.Log("Ball hit trigger");
            EndGame();
        }

        if (other.gameObject.CompareTag("Speed Wall"))
        {
            rb.AddForce(new Vector3(-1, 0, 0) * 5.0f, ForceMode.Impulse);
        }
        if (other.gameObject.CompareTag("Wall Trigger"))
        {
            ClosingWall.SetActive(true);
        }

    }

    private void OnCollisionEnter(Collision other) 
    {
        if (other.gameObject.CompareTag("Pin"))
        {
            print("Hit pin");
            rb.AddForce(other.GetContact(0).normal * 20.0f, ForceMode.Impulse);
            IncreaseScore(50);
        }    
    }

    void IncreaseScore(int amount)
    {
        score += amount;
    }

    void EndGame()
    {
        Timer timerRef = timerObjectRef.GetComponent<Timer>();
        timerRef.gameOver = true;
    }
}
