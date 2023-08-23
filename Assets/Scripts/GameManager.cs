using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    // Stores the instance of the GameManager
    public static GameManager Instance;

    // Stores the game score
    public int Score;
    public short Lives;

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
    }
}
