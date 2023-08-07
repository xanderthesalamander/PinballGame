using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreBoardNumber : MonoBehaviour
{
    [SerializeField]
    private int number;
    
    private List<Light> upper = new List<Light>();
    private List<Light> upperLeft = new List<Light>();
    private List<Light> upperRight = new List<Light>();
    private List<Light> middle = new List<Light>();
    private List<Light> lowerLeft = new List<Light>();
    private List<Light> lowerRight = new List<Light>();
    private List<Light> lower = new List<Light>();


    // Start is called before the first frame update
    void Start()
    {
        // Set the inital value for the number
        number = 0;

        // Populate the lists with references to each light
        foreach (Transform child in transform){
            if(child.name.Contains("Upper Light")){
                upper.Add(child.GetComponentInChildren<Light>());
                // Light light = child.GetComponentInChildren<Light>();
                // upper.Add(light);
                // light.enabled = false;
            }else if(child.name.Contains("Upper Left Light")){
                upperLeft.Add(child.GetComponentInChildren<Light>());
            }else if(child.name.Contains("Upper Right Light")){
                upperRight.Add(child.GetComponentInChildren<Light>());
            }else if(child.name.Contains("Middle Light")){
                middle.Add(child.GetComponentInChildren<Light>());
            }else if(child.name.Contains("Lower Left Light")){
                lowerLeft.Add(child.GetComponentInChildren<Light>());
            }else if(child.name.Contains("Lower Right Light")){
                lowerRight.Add(child.GetComponentInChildren<Light>());
            }else if(child.name.Contains("Lower Light")){
                lower.Add(child.GetComponentInChildren<Light>());
            }
        }

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Keypad0) || Input.GetKeyDown(KeyCode.Alpha0)){
            SetNumber(0);
        }else if(Input.GetKeyDown(KeyCode.Keypad1) || Input.GetKeyDown(KeyCode.Alpha1)){
            SetNumber(1);
        }else if(Input.GetKeyDown(KeyCode.Keypad2) || Input.GetKeyDown(KeyCode.Alpha2)){
            SetNumber(2);
        }else if(Input.GetKeyDown(KeyCode.Keypad3) || Input.GetKeyDown(KeyCode.Alpha3)){
            SetNumber(3);
        }else if(Input.GetKeyDown(KeyCode.Keypad4) || Input.GetKeyDown(KeyCode.Alpha4)){
            SetNumber(4);
        }else if(Input.GetKeyDown(KeyCode.Keypad5) || Input.GetKeyDown(KeyCode.Alpha5)){
            SetNumber(5);
        }else if(Input.GetKeyDown(KeyCode.Keypad6) || Input.GetKeyDown(KeyCode.Alpha6)){
            SetNumber(6);
        }else if(Input.GetKeyDown(KeyCode.Keypad7) || Input.GetKeyDown(KeyCode.Alpha7)){
            SetNumber(7);
        }else if(Input.GetKeyDown(KeyCode.Keypad8) || Input.GetKeyDown(KeyCode.Alpha8)){
            SetNumber(8);
        }else if(Input.GetKeyDown(KeyCode.Keypad9) || Input.GetKeyDown(KeyCode.Alpha9)){
            SetNumber(9);
        }

        DisplayNumber();
    }

    public void SetNumber(int numberToSet)
    {
        number = numberToSet;
    }

    private void TurnOnLightList(List<Light> lightList)
    {
        foreach(Light light in lightList){
            light.enabled = true;
        }
    }

    private void TurnOffLightList(List<Light> lightList)
    {
        foreach(Light light in lightList){
            light.enabled = false;
        }
    }

    private void TurnAllLightsOn()
    {
        TurnOnLightList(upper);
        TurnOnLightList(upperLeft);
        TurnOnLightList(upperRight);
        TurnOnLightList(middle);
        TurnOnLightList(lowerLeft);
        TurnOnLightList(lowerRight);
        TurnOnLightList(lower);
    }
    
    private void TurnAllLightsOff()
    {
        TurnOffLightList(upper);
        TurnOffLightList(upperLeft);
        TurnOffLightList(upperRight);
        TurnOffLightList(middle);
        TurnOffLightList(lowerLeft);
        TurnOffLightList(lowerRight);
        TurnOffLightList(lower);
    }
    
    private void DisplayNumber()
    {
        TurnAllLightsOn();

        switch(number)
        {
            case 0:
                TurnOffLightList(middle);
                break;
            case 1:
                TurnOffLightList(upper);
                TurnOffLightList(upperLeft);
                TurnOffLightList(middle);
                TurnOffLightList(lowerLeft);
                TurnOffLightList(lower);
                break;
            case 2:
                TurnOffLightList(upperLeft);
                TurnOffLightList(lowerRight);          
                break;
            case 3:
                TurnOffLightList(upperLeft);
                TurnOffLightList(lowerLeft);
                break;
            case 4:
                TurnOffLightList(upper);
                TurnOffLightList(lowerLeft);
                TurnOffLightList(lower);
                break;
            case 5:
                TurnOffLightList(upperRight);
                TurnOffLightList(lowerLeft);
                break;
            case 6:
                TurnOffLightList(upperRight);
                break;
            case 7:
                TurnOffLightList(upperLeft);
                TurnOffLightList(middle);
                TurnOffLightList(lowerLeft);
                TurnOffLightList(lower);
                break;
            case 8:
                break;
            case 9:
                TurnOffLightList(lowerLeft);
                break;

        }
    }
}
