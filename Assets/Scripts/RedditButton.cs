using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RedditButton : MonoBehaviour
{
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
}
