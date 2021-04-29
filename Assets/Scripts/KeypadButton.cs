using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;

using System;

public class KeypadButton : MonoBehaviour
{

    public static event Action<string> ButtonPressed = delegate{};
    public Text inputDisplay;
    public Text notepad;
    
    
    private int pos;
    private string buttonName, buttonValue;
    private static string InputCode;
    private static string realCode;
    private static string progress = "";
    private static bool doneFirst  = false;
    private static bool doneSecond = false;
    private static bool doneThird  = false;
    private static bool doneFourth = false;
    private static bool madeReal   = false;
    
    // Start is called before the first frame update
    void Start()
    {
        InputCode = "";
        inputDisplay.text = "_ _ _ _";
        notepad.text = progress;
        string curr = SceneManager.GetActiveScene().name;
        if ( curr == "Instagram" || curr == "Snapchat" || curr == "Reddit2" || curr == "Snapchat2a")
        {
          changeHidden();
        }
        // buttonName = EventSystem.current.currentSelectedGameObject.name;
        // pos = buttonName.IndexOf("_");
        // buttonValue = buttonName.Substring(0, pos);

        // gameObject.GetComponent<Button>().onClick.AddListener(ButtonClicked);
        // ButtonPressed += AddDigit;
        
    }
    
    //creates random 4 digit code
    public void createCode() {
      realCode = "";
      for (int i = 0; i < 4; i++) {
        realCode += UnityEngine.Random.Range(1,10);
      }
      doneFirst   = false;
      doneSecond  = false;
      doneThird   = false;
      doneFourth  = false;
      notepad.text = "";
      progress     = "";
      Debug.Log("RESET");
      madeReal = true;
    }
    
    //changes text and location of some buttons
    private void changeHidden() {
      if (!madeReal) {
        createCode();
      }
      var x = GameObject.Find("Passcode Stuff");
      var hidden = x.transform.GetChild(0).gameObject.GetComponentInChildren<Text>();
      GameObject hiddenButton = x.transform.GetChild(0).gameObject;
      Vector3    pos          = hiddenButton.transform.position;
      if (SceneManager.GetActiveScene().name == "Instagram") {
          hidden.text = realCode[0] + "";
      }
      else if (SceneManager.GetActiveScene().name == "Snapchat") {
        pos.x += UnityEngine.Random.Range(-10.0f, 150.0f);
        pos.y += UnityEngine.Random.Range(-25.0f, 180.0f);
        hiddenButton.transform.position = pos;
        hidden.text = realCode[1] + "";
      }
      else if (SceneManager.GetActiveScene().name == "Reddit2") {
        pos.y += UnityEngine.Random.Range(-90.0f, 30.0f);
        hiddenButton.transform.position = pos;
        hidden.text = realCode[2] + "";
      }
      else if (SceneManager.GetActiveScene().name == "Snapchat2a") {
        int[]      yCords       = new int[]{-293,-170,-47,76,199,322};
        pos.y = yCords[UnityEngine.Random.Range(0,6)];
        Debug.Log(pos.y);
        hiddenButton.transform.position = pos;
        hidden.text = realCode[3] + "";
      }
    }
    
    //adds digit to notepad
    public void addNote() 
    {
      if (SceneManager.GetActiveScene().name == "Instagram") {
        if(!doneFirst){
          notepad.text += realCode[0] + "";
          progress += realCode[0] + "";
          doneFirst = true;
        }
      }
      else if (SceneManager.GetActiveScene().name == "Snapchat") {
        if(!doneSecond){
          notepad.text += realCode[1] + "";
          progress += realCode[1] + "";
          doneSecond = true;
        }
      }
      else if (SceneManager.GetActiveScene().name == "Reddit2") {
        if(!doneThird){
          notepad.text += realCode[2] + "";
          progress += realCode[2] + "";
          doneThird = true;
        }
      }
      else if (SceneManager.GetActiveScene().name == "Snapchat2a") {
        if(!doneFourth){
          notepad.text += realCode[3] + "";
          progress += realCode[3] + "";
          doneFourth = true;
        }
      }
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
            inputDisplay.text = InputCode;
            for (int i = 0; i < 4-InputCode.Length; i++) {
              inputDisplay.text += "_ ";
            }
        }
        if(InputCode.Length == 4)
        {
          inputDisplay.text = InputCode;
          CheckResults();
        }


    }

    private void CheckResults()
    {
        Debug.Log(InputCode);
        if(InputCode == realCode)    // CORRECT CODE HERE
        {
            Debug.Log("correct"); //Put scenes here
            SceneManager.LoadScene("Win");  //win the game
        }
        else
        {
            Debug.Log("incorrect");
            inputDisplay.text = "INCORRECT";
        }

        InputCode = "";

    }

}
