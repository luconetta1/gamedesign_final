using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Start_Button : MonoBehaviour
{
    public void NextScene()
    {
        string currScene = SceneManager.GetActiveScene().name;
        if (currScene == "Win" ||  currScene == "Play" || currScene == "Pause") {
          SceneManager.LoadScene("Home");
        }
        else {
          SceneManager.LoadScene("Reddit");
        }
    }
}

