using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpotLightOnBall : MonoBehaviour
{
    // Start is called before the first frame update
    public Vector3 offset;
    
    void Start()
    {
     
    }

    // Update is called once per frame
    void Update()
    {
        GameObject ball = GameObject.FindGameObjectWithTag("ball");
        

        transform.position = ball.transform.position + offset;
    }
}
