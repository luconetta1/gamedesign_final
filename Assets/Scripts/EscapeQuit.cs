using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.EventSystems;

public class EscapeQuit : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
      //go to main page when escape key pressed
      if (Input.GetKey ("escape")) {
        SceneManager.LoadScene("Play");
      }
        
    }
}
