using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Start_Button : MonoBehaviour
{
    public void NextScene()
    {
        if (SceneManager.GetActiveScene().name == "Win" || SceneManager.GetActiveScene().name == "Play") {
          SceneManager.LoadScene("Home");
        }
        else {
          SceneManager.LoadScene("Reddit");
        }
    }
}

