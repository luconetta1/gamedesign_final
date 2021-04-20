using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class snapchat1 : MonoBehaviour
{
    public GameObject popup;
    //public AudioSource ding;
    
    void Start()
    {
        popup = GameObject.Find("popup");
        popup.SetActive(false); 

        Invoke("POP", 2.0f);
      
    }

    void POP()
    {
         popup.SetActive(true);
         //ding.Play();
    }

    public void to_chat() 
    {
        string currScene = SceneManager.GetActiveScene().name;
        
        if (currScene == "Snapchat") {
          SceneManager.LoadScene("Snapchat1a");
        }
        else {
          SceneManager.LoadScene("Snapchat2a");
        }
    }
    
    public void next_scene()
    {
      int y = SceneManager.GetActiveScene().buildIndex; //current scene index
      
      if (y == 3) {
        SceneManager.LoadScene("Message3");  //third message
      }
      else {
        SceneManager.LoadScene("Message5"); //fifth message
      }
    }
}
