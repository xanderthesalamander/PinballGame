using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rockTable : MonoBehaviour
{
    public GameObject pinballTable;
    // Start is called before the first frame update
    public bool flippedRight = false;
    public bool flippedLeft = false;
    public bool normal = true;
    public float flipStartTime = 0;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        bool spaceBar = Input.GetKeyDown(KeyCode.Space);
        if (spaceBar)
        {
            flipStartTime = Time.time;
            normal = false;
            flippedRight = true;
        }
        if (flippedRight)
        {
            if (Time.time - flipStartTime < 0.5)
            {
                pinballTable.transform.localRotation = Quaternion.Euler(0.0f, 0.0f, Mathf.Sin(Time.time * 20) * 5.0f);
            }
            else
            {
                pinballTable.transform.localRotation = Quaternion.Euler(0.0f, 0.0f, 0.0f);
                normal = true;
                flippedRight = false;
            }

        }

    }
}
