using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.EventSystems;

public class message : MonoBehaviour
{

    public static GameObject message1;
    public static GameObject message2;
    public static GameObject message3;
    public GameObject nextButton;
    public AudioSource click;
    //can use more/less messages depending on scene

   // public AudioSource ding;


    // Start is called before the first frame update
    void Start()
    {
        message1 = GameObject.Find("message1");
        message2 = GameObject.Find("message2");
        message3 = GameObject.Find("message3");
        
        message1.SetActive(false); 
        message2.SetActive(false); 
        message3.SetActive(false); 
        nextButton.SetActive(false);


        Invoke("msg1", 1.0f);
    }
    

    public void msg1()
    {
        message1.SetActive(true);
       //  ding.Play();
    }
    
    public void makeActive() {
        nextButton.SetActive(true);
    }
    
    public void nextScene() {
      string currScene = SceneManager.GetActiveScene().name;
      if ( currScene == "Message1") {
        SceneManager.LoadScene("Instagram");  //Insta Level 1
      }
      else if ( currScene == "Message2") {
        SceneManager.LoadScene("Snapchat");  //Snap Level 1
      }
      else if ( currScene == "Message3") {
        SceneManager.LoadScene("Reddit2");  //Reddit Level 2
      }
      else if ( currScene == "Message4") {
        SceneManager.LoadScene("Snapchat2");  //Snap Level 2
      }
      else if ( currScene == "Message5") {
        SceneManager.LoadScene("Instagram2");  //Insta Level 2
      }
      else if ( currScene == "Message6") {
        SceneManager.LoadScene("keypad");  //Insta Level 2
      }
    }
    
    public void playClick() {
      click.Play();
    }
}