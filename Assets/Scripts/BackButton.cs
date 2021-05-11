using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.EventSystems;

public class BackButton : MonoBehaviour
{ 
    private static int progress;

    public GameObject nextButton;

    public static int reddit1 = 0;
    public static int reddit2 = 0;

    public static string reddit1_string = "Reddit";
    public static string reddit2_string = "Reddit2";


  

    
    void Start() {
      int temp_reddit1 = Random.Range(1,4);
      int temp_reddit2 = Random.Range(1,4);

      if(reddit1 == 0){
        reddit1 = temp_reddit1;
      }

      if(reddit2 == 0){
        reddit2 = temp_reddit2;
      }

      if(reddit1 == 2){
          reddit1_string = "Reddit1b";
      }else if(reddit1 == 3){
          reddit1_string = "Reddit1c";
      }

    

     if(reddit2 == 2){
          reddit2_string = "Reddit2b";
      }else if(reddit2 == 3){
          reddit2_string = "Reddit2c";
      }         
      var levels = new Dictionary<string, int>() {
        {"Home", 1}, {"Reddit", 2}, {"Reddit1b", 2},  {"Reddit1c", 2}, {"Message1", 3},
        {"Instagram", 4}, {"Message2", 5}, {"Snapchat", 6},
        {"Snapchat1a", 7}, {"Message3", 8}, {"Reddit2", 9}, {"Reddit2b", 9},
        {"Reddit2c", 9}, {"Message4", 10}, {"Snapchat2", 11}, {"Snapchat2a", 12},
        {"Message5", 13}, {"Instagram2", 14}, {"Message6", 15},
        {"keypad", 0}, {"Lose", 0}, {"Pause", 0}
      };
      
      string currLevel = SceneManager.GetActiveScene().name;
      if (progress >= levels[currLevel]) {
        nextButton.SetActive(true);
      }
      else {
        nextButton.SetActive(false);
        progress = levels[currLevel]-1;
      }
      
    }
  
    
    public void goBack() 
    {
      string curr = SceneManager.GetActiveScene().name;
      
      switch(curr) {
        case "keypad":
          SceneManager.LoadScene("Message6");
          progress = 15;
          break;
        case "Message6":
          SceneManager.LoadScene("Instagram2");
          if (progress < 14) 
            progress = 14;
          break;
        case "Instagram2":
          SceneManager.LoadScene("Message5");
          if (progress < 13) 
            progress = 13;
          break;
        case "Message5":
          SceneManager.LoadScene("Snapchat2a");
          if (progress < 12) 
            progress = 12;
          break;
        case "Snapchat2a":
          SceneManager.LoadScene("Snapchat2");
          if (progress < 11) 
            progress = 11;
          break;
        case "Snapchat2":
          SceneManager.LoadScene("Message4");
          if (progress < 10) 
            progress = 10;
          break;
        case "Message4":
            SceneManager.LoadScene(reddit2_string);
          if (progress < 9) 
            progress = 9;
          break;
        case "Reddit2":
          SceneManager.LoadScene("Message3");
          if (progress < 8) 
            progress = 8;
          break;
         case "Reddit2b":
            SceneManager.LoadScene("Message3");
            if (progress < 8) 
            progress = 8;
          break;
        case "Reddit2c":
            SceneManager.LoadScene("Message3");
            if (progress < 8) 
            progress = 8;
          break;
        case "Message3":
          SceneManager.LoadScene("Snapchat1a");
          if (progress < 7) 
            progress = 7;
          break;
        case "Snapchat1a":
          SceneManager.LoadScene("Snapchat");
          if (progress < 6) 
            progress = 6;
          break;
        case "Snapchat":
          SceneManager.LoadScene("Message2");
          if (progress < 5) 
            progress = 5;
          break;
        case "Message2":
          SceneManager.LoadScene("Instagram");
          if (progress < 10) 
            progress = 4;
          break;
        case "Instagram":
          SceneManager.LoadScene("Message1");
          if (progress < 3) 
            progress = 3;
          break;
        case "Message1":
          SceneManager.LoadScene(reddit1_string);
          if (progress < 2) 
            progress = 2;
          break;
        case "Reddit":
          SceneManager.LoadScene("Home");
          if (progress < 1) 
            progress = 1;
          break;  
         case "Reddit1b":
            SceneManager.LoadScene("Home");
            if (progress < 1) 
            progress = 1;
          break;
        case "Reddit1c":
            SceneManager.LoadScene("Home");
            if (progress < 1) 
            progress = 1;
          break;
      }
    }
    
    
    public void goNext() 
    {
      string curr = SceneManager.GetActiveScene().name;
      
      switch(curr) {
        case "Home":
          SceneManager.LoadScene(reddit1_string);
          break;
        case "Reddit":
          SceneManager.LoadScene("Message1");
          break;
         case "Reddit1b":
            SceneManager.LoadScene("Message1");
          break;
        case "Reddit1c":
            SceneManager.LoadScene("Message1");
        break;
        case "Message1":
          SceneManager.LoadScene("Instagram");
          break;
        case "Instagram":
          SceneManager.LoadScene("Message2");
          break;
        case "Message2":
          SceneManager.LoadScene("Snapchat");
          break;
        case "Snapchat":
          SceneManager.LoadScene("Snapchat1a");
          break;
        case "Snapchat1a":
          SceneManager.LoadScene("Message3");
          break;
        case "Message3":
          SceneManager.LoadScene(reddit2_string);
          break;
        case "Reddit2":
            SceneManager.LoadScene("Message4");
          break;
        case "Reddit2b":
            SceneManager.LoadScene("Message4");
          break;
        case "Reddit2c":
            SceneManager.LoadScene("Message4");
        break;
        case "Message4":
          SceneManager.LoadScene("Snapchat2");
          break;
        case "Snapchat2":
          SceneManager.LoadScene("Snapchat2a");
          break;
        case "Snapchat2a":
          SceneManager.LoadScene("Message5");
          break;
        case "Message5":
          SceneManager.LoadScene("Instagram2");
          break;
        case "Instagram2":
          SceneManager.LoadScene("Message6");
          break;
        case "Message6":
          SceneManager.LoadScene("keypad");
          break;
      }
    }
    
    public void startOver() {
      progress = 0;
    }
}
