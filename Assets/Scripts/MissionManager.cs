using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MissionManager : MonoBehaviour
{
    public Animator missionStateAnimator;

    // Start is called before the first frame update
    void Start()
    {
        missionStateAnimator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if(missionStateAnimator.GetCurrentAnimatorStateInfo(0).IsName("Between Missions")){
            Debug.Log("Between Missions");
        }
        //missionStateAnimator.Set[Bool]("MissionComplete", true)
    }
}
