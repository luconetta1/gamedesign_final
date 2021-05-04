using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.EventSystems;

public class InstaButtons : MonoBehaviour
{
  
    public AudioSource click;
  
    public void findNextScene() {
      if (SceneManager.GetActiveScene().name == "Instagram") {
        if (EventSystem.current.currentSelectedGameObject.name == "Comment") {
            SceneManager.LoadScene("Message2");  //second message scene
        }
        else {
          SceneManager.LoadScene("Lose");  // lose scene
        }
      }
      else {
        if (EventSystem.current.currentSelectedGameObject.name == "Like") {
            SceneManager.LoadScene("Message6");  //6th message
        }
        else {
          SceneManager.LoadScene("Lose");  // lose scene
        }
      }
    }
    
    public void clickNoise() {
      click.Play();
    }
}
