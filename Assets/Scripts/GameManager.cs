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
        
    }

    public void Start()
    {
        Score = 0;
        Lives = 3;
        Confetti = GameObject.Find("Confetti").GetComponent<ParticleSystem>();
    }

    public void Update()
    {
        

        
    }

    public void deadBall(){
        if(Score > HighScore){
            HighScore = Score;
        }

    }
    

    public void endGame(){     
        if(Score >= HighScore){
            var emission = Confetti.emission;
            emission.rateOverTime = HighScore;
            Confetti.Play();
        }
        
    }
}
