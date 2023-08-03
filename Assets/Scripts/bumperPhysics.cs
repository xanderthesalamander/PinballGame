using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;
using UnityEngine.UI;

public class bumperPhysics : MonoBehaviour
{
    public static int score=0;
    // Start is called before the first frame update
    float explosionBoundValue;
    float explosionBoundRadius;

    [SerializeField]

    public Vector3 localScale;
    //private bool objCollided = false;
    private float collideStartTime = 0;
    [SerializeField]
    Canvas scoreCanvas;
        
    void Start()
    {
        //scoreboard = GetComponent<Text>();
        score = 0;
        localScale = transform.localScale;
        
        
    }
    private void OnCollisionEnter(Collision collision)
    {
        //if(collision.gameObject.tag == "ball")
        //{
            explosionBoundValue = Random.Range(35.0f, 55.0f);
            explosionBoundRadius = Random.Range(35.0f, 50.0f);

            collision.rigidbody.AddExplosionForce(explosionBoundValue, transform.position, explosionBoundRadius);
        ScoreKeeper sk = scoreCanvas.GetComponent<ScoreKeeper>();
        sk.scoreAdd();
        //objCollided = true;
        collideStartTime = Time.time;
           Debug.Log(explosionBoundRadius);
        //}
        
    }
    private void Update()
    {
    }
}
