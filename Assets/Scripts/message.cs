using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class message : MonoBehaviour
{

    public static GameObject message1;
    public static GameObject message2;
    public static GameObject message3;
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


        Invoke("msg1", 1.0f);
    }
    

    public void msg1()
    {
        message1.SetActive(true);
       //  ding.Play();
    }
}