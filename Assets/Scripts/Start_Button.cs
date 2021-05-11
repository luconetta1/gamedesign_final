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
          Debug.Log(BackButton.reddit1);
          SceneManager.LoadScene(BackButton.reddit1_string);
        }
    }
}

