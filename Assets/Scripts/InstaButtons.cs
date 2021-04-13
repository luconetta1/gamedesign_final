using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.EventSystems;

public class InstaButtons : MonoBehaviour
{
    public void findNextScene() {
      if (EventSystem.current.currentSelectedGameObject.name == "Comment") {
        if (SceneManager.GetActiveScene().name == "Instagram") {
          SceneManager.LoadScene("Reddit2");  //second level
        }
        else {
          SceneManager.LoadScene("Win");
        }
      }
      else {
        SceneManager.LoadScene("Lose");  // lose scene
      }
    }
}
