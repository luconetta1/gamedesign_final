using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.EventSystems;

public class SnapButton : MonoBehaviour
{
  public void findNextScene() {
    if (EventSystem.current.currentSelectedGameObject.name == "Snap") {
      SceneManager.LoadScene(3);  //win scene
    }
    else {
      SceneManager.LoadScene(4);  // lose scene
    }
  }
}
