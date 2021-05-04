using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.EventSystems;

public class EscapeQuit : MonoBehaviour
{
    private static string lastScene;

    // Update is called once per frame
    void Update()
    {
      //go to main page when escape key pressed
      if (Input.GetKey ("escape")) {
        lastScene = SceneManager.GetActiveScene().name;
        SceneManager.LoadScene("Pause");
      }
        
    }
    
    public void resumeGame() {
      SceneManager.LoadScene(lastScene);
    }
}
