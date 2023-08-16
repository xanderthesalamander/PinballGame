using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ballMovement : MonoBehaviour
{
    // Start is called before the first frame update
    Rigidbody rb;
// AudioSource audioSource;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
  //      audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
