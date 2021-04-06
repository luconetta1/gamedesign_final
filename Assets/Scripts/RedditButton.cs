using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;



public class RedditButton : MonoBehaviour
{

  public static int b1 = 0;
  public static int b2 = 0;
  public static int b3 = 0;
  public static int b4 = 0;
  

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
      int y = SceneManager.GetActiveScene().buildIndex;
      
      //go to next reddit question
      if (y == 1) {
        SceneManager.LoadScene(2);
      }
      //or (going to change as we add more levels) WIN
      else {
        SceneManager.LoadScene(3);
      }
  }

  public void setb1(){
    b1 = 1;
  }

  public void resetb1(){
    b1 = 0;
  }

   public void setb2(){
    b2 = 1;
  }

  public void resetb2(){
    b2 = 0;
  }

   public void setb3(){
    b3 = 1;
  }

  public void resetb3(){
    b3 = 0;
  }

   public void setb4(){
    b4 = 1;
  }

  public void resetb4(){
    b4 = 0;
  }
}


