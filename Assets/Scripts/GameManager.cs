using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    // Stores the instance of the GameManager
    public static GameManager Instance;

    // Stores the game score
    public int HighScore;
    public int Score;
    public short Lives;
    ParticleSystem Confetti;
    AudioSource BGM;

    private void Awake()
    {
        // Singleton to prevent multiple GameManagers from existing
        if(Instance != null)
        {
            Destroy(gameObject);
            return;
        }
        Instance = this;
        DontDestroyOnLoad(gameObject);
        Confetti = GameObject.Find("Confetti").GetComponent<ParticleSystem>();
        BGM = GameObject.Find("BGM").GetComponent<AudioSource>();
        BGM.Play();
    }

    public void Start()
    {
        Score = 0;
        Lives = 3;
    }

    public void Update()
    {
        
    }

    public void deadBall(){
        if(Score > HighScore){
            HighScore = Score;
        }
        if(Lives == 3){
            BGM.pitch = 2;
        } else if (Lives == 2){
            BGM.pitch = 3;
        } else {
            BGM.pitch = 1;
        }
        
    }
    

    public void endGame(){     
        if(Score >= HighScore){
            var emission = Confetti.emission;
            if(Score > 500){
                emission.rateOverTime = HighScore/2;
            } else {
                emission.rateOverTime = HighScore;
            }
            
            Confetti.Play();
        }
    }
}
