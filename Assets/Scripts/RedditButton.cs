using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;



public class RedditButton : MonoBehaviour
{

  public static int b1 = 0;
  public static int b2 = 0;
  public static int b3 = 0;
  public static int b4 = 0;
  
  public Button button;
  public Sprite feedback;   //feedback button image (for when correct)
  public Sprite original;   //regular button image
  

  void Update(){
    if(b1 == 1 && b2 == 1 && b3 == 1 && b4 == 1){
      b1 = 0;
      b2 = 0;
      b3 = 0;
      b4 = 0;
      NextScene();
    }
  }

  public void NextScene()
  {
      string currScene = SceneManager.GetActiveScene().name;
      
      //go to fourth message
      if (currScene == "Reddit2") {
        SceneManager.LoadScene("Message4");
      }
      //or go to first message scene after first reddit puzzle
      else {
        SceneManager.LoadScene("Message1");
      }
      
      //skip straight to insta for now
      
  }

  public void setb1(){
    b1 = 1;
    button.GetComponent<Image>().sprite = feedback;
  }

  public void resetb1(){
    b1 = 0;
    button.GetComponent<Image>().sprite = original;
  }

   public void setb2(){
    b2 = 1;
    button.GetComponent<Image>().sprite = feedback;
  }

  public void resetb2(){
    b2 = 0;
    button.GetComponent<Image>().sprite = original;
  }

   public void setb3(){
    b3 = 1;
    button.GetComponent<Image>().sprite = feedback;
  }

  public void resetb3(){
    b3 = 0;
    button.GetComponent<Image>().sprite = original;
  }

   public void setb4(){
    b4 = 1;
    button.GetComponent<Image>().sprite = feedback;
  }

  public void resetb4(){
    b4 = 0;
    button.GetComponent<Image>().sprite = original;
  }
}


