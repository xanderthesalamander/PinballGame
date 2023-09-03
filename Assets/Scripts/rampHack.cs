using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class rampHack : MonoBehaviour
{
    [SerializeField]
    GameObject target;

    [SerializeField]
    float rampHitProbability = 1.0f;

    [SerializeField]
    float power = 0f;

    GameObject flipper;
    Vector3 force;
    List<Rigidbody> balls;
    public string InputName;

    // Start is called before the first frame update
    void Start() {
        balls = new List<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        // Check if flipper is pressed
        bool flipperPressed = Input.GetAxis(InputName) == 1;
        // Check ball in trigger
        bool ballInRange = balls.Count > 0;
        if (flipperPressed) {
            // Debug.Log("Pressed");
            foreach (Rigidbody ball in balls) {
                // Chance
                bool chance = Random.Range(0, 1) <= rampHitProbability;
                if (chance) {
                    // Debug.Log("Shoot");
                    // Apply force towards target
                    Vector3 force = power * (target.transform.position - ball.transform.position);
                    ball.AddForce(force);
                }
            }
        }
    }

    private void OnTriggerEnter(Collider other) {
        if (other.gameObject.tag == "ball") {
            // Debug.Log("Ball is in flipper trigger");
            // Add ball to list of balls
            balls.Add(other.gameObject.GetComponent<Rigidbody>());
            // Debug.Log("Balls: " + balls.Count);
        }
    }


    private void OnTriggerExit(Collider other) {
        if (other.gameObject.tag == "ball") {
            // Debug.Log("Ball left flipper trigger");
            // Remove ball from list of balls
            balls.Remove(other.gameObject.GetComponent<Rigidbody>());
            // Debug.Log("Balls: " + balls.Count);
        }
    }

}
