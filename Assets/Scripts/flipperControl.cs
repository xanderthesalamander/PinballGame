using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class flipperControl : MonoBehaviour
{
    float restPosition = 0f;
    float pressedPosition = 60f;
    float flipperStrength = 25000f;
    float flipperDamper = 150f;
    public string InputName;
    HingeJoint joint;
    AudioSource flipperHitAudio;

    // boolean to check if the flipper is flipped - so the audio doesnt loop.
    bool flipped = false;
    //GameObject scoreCanvas;

    
    

    // Start is called before the first frame update
    void Start()
    {
        joint = GetComponent<HingeJoint>();
        // scoreCanvas = GameObject.FindGameObjectWithTag("scoreCanvas");

        flipperHitAudio = GetComponent<AudioSource>();

    }

    // Update is called once per frame
    void Update()
    {
        JointSpring spring = new JointSpring();
        JointLimits jlimits = new JointLimits();
        spring.spring = flipperStrength;
        spring.damper = flipperDamper;
        jlimits.max = 60F;
        jlimits.min = -45F;
        // ScoreKeeper sk = scoreCanvas.GetComponent<ScoreKeeper>();

        if (Input.GetAxis(InputName) == 1)
        {
            if (InputName == "LFlipper")
            {
                spring.targetPosition = pressedPosition * -1;
            }
            else
            {
                spring.targetPosition = pressedPosition;
            }
            
            //  sk.score += 1;
            if(!flipperHitAudio.isPlaying && !flipped)
            {
                flipperHitAudio.Play();
            }
            flipped = true;


        } else
        {
            if(InputName == "LFlipper")
            {
                spring.targetPosition = restPosition * -1;
            } else
            {
                spring.targetPosition = restPosition;
            }
            flipped = false;
        }
        
        
        joint.limits = jlimits;
        joint.spring = spring;

    }
}
