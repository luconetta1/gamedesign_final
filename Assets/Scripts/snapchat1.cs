using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class snapchat1 : MonoBehaviour
{
    public GameObject popup;
    //public AudioSource ding;
    public GameObject ans1;
    public GameObject ans2;
    public GameObject correctAns;
    public GameObject ans4;
    public GameObject ans5;
    public GameObject ans6;
    
    void Start()
    {
        randomOrder();
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
      string currScene = SceneManager.GetActiveScene().name;
      if (currScene == "Snapchat1a") {
        SceneManager.LoadScene("Message3");  //third message
      }
      else {
        SceneManager.LoadScene("Message5"); //fifth message
      }
    }
    
    private void randomOrder() {
      Vector3 pos1 = ans1.transform.position;
      Vector3 pos2 = ans2.transform.position;
      Vector3 pos3 = correctAns.transform.position;
      Vector3 pos4 = ans4.transform.position;
      Vector3 pos5 = ans5.transform.position;
      Vector3 pos6 = ans6.transform.position;
      
      Vector3[] positions = new Vector3[]{pos1,pos2,pos3,pos4,pos5,pos6};
      bool[]    beenUsed  = new bool[]{false,false,false,false,false,false,true};
      GameObject[] buttons = new GameObject[]{ans1,ans2,correctAns,ans4,ans5,ans6};
      
      for (int i = 0; i < buttons.Length; i++) {
        int j = 6;
        while (beenUsed[j]) {
         j = UnityEngine.Random.Range(0,positions.Length);
        }
        buttons[i].transform.position = positions[j];
        beenUsed[j] = true;
      }
    }
}
