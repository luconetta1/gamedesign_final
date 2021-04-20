using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;

public class Digits : MonoBehaviour
{
    public Text notepad;
    
    private static string progress = "";
    
    // Start is called before the first frame update
    void Start()
    {
      
      notepad.text = progress;
    }

    public void addNote() 
    {
      if (SceneManager.GetActiveScene().name == "Instagram") {
        notepad.text += "7";
        progress += "7";
      }
      else if (SceneManager.GetActiveScene().name == "Snapchat") {
        notepad.text += "6";
        progress += "6";
      }
      else if (SceneManager.GetActiveScene().name == "Reddit2") {
        notepad.text += "2";
        progress += "2";
      }
      else if (SceneManager.GetActiveScene().name == "Snapchat2a") {
        notepad.text += "3";
        progress += "3";
      }
    }
}
