using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.EventSystems;

public class BackButton : MonoBehaviour
{
    public void goBack() 
    {
      string curr = SceneManager.GetActiveScene().name;
      
      switch(curr) {
        case "keypad":
          SceneManager.LoadScene("Message6");
          break;
        case "Message6":
          SceneManager.LoadScene("Instagram2");
          break;
        case "Instagram2":
          SceneManager.LoadScene("Message5");
          break;
        case "Message5":
          SceneManager.LoadScene("Snapchat2a");
          break;
        case "Snapchat2a":
          SceneManager.LoadScene("Snapchat2");
          break;
        case "Snapchat2":
          SceneManager.LoadScene("Message4");
          break;
        case "Message4":
          SceneManager.LoadScene("Reddit2");
          break;
        case "Reddit2":
          SceneManager.LoadScene("Message3");
          break;
        case "Message3":
          SceneManager.LoadScene("Snapchat1a");
          break;
        case "Snapchat1a":
          SceneManager.LoadScene("Snapchat");
          break;
        case "Snapchat":
          SceneManager.LoadScene("Message2");
          break;
        case "Message2":
          SceneManager.LoadScene("Instagram");
          break;
        case "Instagram":
          SceneManager.LoadScene("Message1");
          break;
        case "Message1":
          SceneManager.LoadScene("Reddit");
          break;
        case "Reddit":
          SceneManager.LoadScene("Home");
          break;  
      }
    }
}
