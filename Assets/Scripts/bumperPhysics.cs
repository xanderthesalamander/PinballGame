using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;
using UnityEngine.UI;

public class bumperPhysics : MonoBehaviour
{
    [SerializeField]
    Canvas scoreCanvas;
    [SerializeField]
    float minForce = 200.0f;
    [SerializeField]
    float maxForce = 400.0f;

    public static int score = 0;
    // Explosion parameters (will be randomised)
    float explosionBoundValue;
    float explosionBoundRadius;

    // Start is called before the first frame update    
    void Start()
    {
        score = 0;
    }

    // Triggered when something collides with the object
    private void OnCollisionEnter(Collision collision)
    {
        // If collision with a ball object
        if (collision.gameObject.tag == "ball")
        {
            // Debug.Log("Ball hit");
            // Force value is random between 
            explosionBoundValue = Random.Range(minForce, maxForce);
            explosionBoundRadius = Random.Range(50.0f, 70.0f);
            // Debug.Log("Explosion value: " + explosionBoundValue);
            // Debug.Log("Explosion radius: " + explosionBoundRadius);
            // Add explosion force
            collision.rigidbody.AddExplosionForce(explosionBoundValue, transform.position, explosionBoundRadius);
            // Add to the score
            ScoreKeeper sk = scoreCanvas.GetComponent<ScoreKeeper>();
            sk.scoreAdd();
        }
    }
}
