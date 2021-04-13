using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.EventSystems;

public class InstaButtons : MonoBehaviour
{
    public void findNextScene() {
      if (EventSystem.current.currentSelectedGameObject.name == "Comment") {
        SceneManager.LoadScene("Reddit2");  //snapchat scene
      }
      else {
        SceneManager.LoadScene("Lose");  // lose scene
      }
    }
}
