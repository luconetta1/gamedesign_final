using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class snapchat1 : MonoBehaviour
{
    public GameObject popup;
    
    void Start()
    {
        popup = GameObject.Find("popup");
        popup.SetActive(false); 

        Invoke("POP", 2.0f);
    }

    void POP()
    {
         popup.SetActive(true); 
    }

    public void to_chat() 
    {
        SceneManager.LoadScene("Snapchat1a");
    }
    
    public void next_scene()
    {
        SceneManager.LoadScene("Instagram");
    }
}
