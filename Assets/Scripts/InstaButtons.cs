using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.EventSystems;

public class InstaButtons : MonoBehaviour
{
    public CameraShake camerashaker;


    public void findNextScene() {
      if (SceneManager.GetActiveScene().name == "Instagram") {
        if (EventSystem.current.currentSelectedGameObject.name == "Comment") {
            SceneManager.LoadScene("Message2");  //second message scene
        }
        else {
        //  StartCoroutine(camerashaker.Shake(.5f, 2f));
          SceneManager.LoadScene("Lose");  // lose scene
        }
      }
      else {
        if (EventSystem.current.currentSelectedGameObject.name == "Like") {
            SceneManager.LoadScene("Message6");  //6th message
        }
        else {
         // StartCoroutine(camerashaker.Shake(.5f, 2f));

          SceneManager.LoadScene("Lose");  // lose scene
        }
      }
    }
}
