using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LifeCounter : MonoBehaviour
{
    private ScoreBoardNumber digit;

    // Start is called before the first frame update
    void Start()
    {
        // Populate the digits array
        digit = GetComponentInChildren<ScoreBoardNumber>();
    }

    // Update is called once per frame
    void Update()
    {
        digit.SetNumber(GameManager.Instance.Lives);
    }


}
