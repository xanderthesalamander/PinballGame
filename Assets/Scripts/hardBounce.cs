using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hardBounce : MonoBehaviour
{
    // Start is called before the first frame update
    float explosionBoundValue;
    float explosionBoundRadius;
    void Start()
    {
        
    }
    private void OnCollisionEnter(Collision collision)
    {
        //if(collision.gameObject.tag == "ball")
        //{
            explosionBoundValue = Random.Range(25.0f, 45.0f);
            explosionBoundRadius = Random.Range(25.0f, 30.0f);
            collision.rigidbody.AddExplosionForce(explosionBoundValue, transform.position, explosionBoundRadius);
            Debug.Log(explosionBoundRadius);
        //}
        
    }
}
