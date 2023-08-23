using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameEnd : MonoBehaviour
{
    // Start is called before the first frame update
    AudioSource gameEndAudioSource;
    ReloadScene rs;
    void Start()
    {
        gameEndAudioSource = GetComponent<AudioSource>();
        rs = GameObject.Find("ReloadTrigger").GetComponent<ReloadScene>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "ball")
        {
            //Debug.Log("Minus 1 Life");
            rs.deadBall();
            gameEndAudioSource.Play();
        }
        //Debug.Log(other.gameObject.tag);
    }
}
