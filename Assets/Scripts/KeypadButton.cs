using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

using System;

public class KeypadButton : MonoBehaviour
{

    public static event Action<string> ButtonPressed = delegate{};

    private int pos;
    private string buttonName, buttonValue;
    private static string InputCode;
    // Start is called before the first frame update
    void Start()
    {
        InputCode = "";
        // buttonName = EventSystem.current.currentSelectedGameObject.name;
        // pos = buttonName.IndexOf("_");
        // buttonValue = buttonName.Substring(0, pos);

        // gameObject.GetComponent<Button>().onClick.AddListener(ButtonClicked);
        // ButtonPressed += AddDigit;
        
    }

    public void button_click(Button btn)
    {
        buttonName = btn.name;
        pos = buttonName.IndexOf("_");
        buttonValue = buttonName.Substring(0, pos);

        AddDigit(buttonValue);
    }
    // private void ButtonClicked()
    // {
    //     ButtonPressed(buttonValue);
    // }


    private void AddDigit(string digit)
    {

       // Debug.Log(digit);
        //Debug.Log(InputCode);

        if(InputCode.Length < 4)
        {
            switch(digit)
            {
                case "One":
                    InputCode += "1";
                    break;
                case "Two":
                    InputCode += "2";
                    break;
                case "Three":
                    InputCode += "3";
                    break;
                case "Four":
                    InputCode += "4";
                    break;
                case "Five":
                    InputCode += "5";
                    break;
                case "Six":
                    InputCode += "6";
                    break;
                case "Seven":
                    InputCode += "7";
                    break;
                case "Eight":
                    InputCode += "8";
                    break;
                case "Nine":
                    InputCode += "9";
                    break;
            
            }
        }
        if(InputCode.Length == 4)
        {
        CheckResults();
        }


    }

    private void CheckResults()
    {
        Debug.Log(InputCode);
        if(InputCode == "1234")    // CORRECT CODE HERE
        {
            Debug.Log("correct"); //Put scenes here
        }
        else
        {
            Debug.Log("incorrect");
        }

        InputCode = ""; 

    }

}
