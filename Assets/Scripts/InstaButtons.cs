using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.EventSystems;

public class InstaButtons : MonoBehaviour
{
    public void findNextScene() {
      if (SceneManager.GetActiveScene().name == "Instagram") {
        if (EventSystem.current.currentSelectedGameObject.name == "Comment") {
            SceneManager.LoadScene("Reddit2");  //second level
        }
        else {
          SceneManager.LoadScene("Lose");  // lose scene
        }
      }
      else {
        if (EventSystem.current.currentSelectedGameObject.name == "Like") {
            SceneManager.LoadScene("Win");  //second level
        }
        else {
          SceneManager.LoadScene("Lose");  // lose scene
        }
      }
    }
}
