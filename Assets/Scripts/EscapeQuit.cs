using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.EventSystems;

public class EscapeQuit : MonoBehaviour
{
    private static string lastScene;
    public AudioSource click;

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
      click.Play();
      SceneManager.LoadScene(lastScene);
    }
    
    public void QuitGame() {
        click.Play();
        #if UNITY_EDITOR 
        UnityEditor.EditorApplication.isPlaying = false; 
        #else 
        Application.Quit(); 
        #endif
    }
}
