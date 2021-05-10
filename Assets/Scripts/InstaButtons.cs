using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class InstaButtons : MonoBehaviour
{
  
    public AudioSource click;
    
    public Sprite search;
    public Sprite shop;
    public Sprite home;
    public Sprite comment;
    public Sprite like;
    public Image post;
    
    private string hidden;
    private static int i;
    private string[] options = new string[]{"Search","Shop","Home","Comment","Like"};
    
    void Start() {
      string currScene = SceneManager.GetActiveScene().name;
      if (currScene == "Instagram") {
        hidden = options[i];
        
        Sprite[] pics = new Sprite[]{search,shop,home,comment,like};
        post.sprite = pics[i];
        
      }
    }
    
    public void setI() {
      i  = UnityEngine.Random.Range(0,options.Length);
      Debug.Log(i);
    }
  
    public void findNextScene() {
      if (SceneManager.GetActiveScene().name == "Instagram") {
        if (EventSystem.current.currentSelectedGameObject.name == hidden) {
            SceneManager.LoadScene("Message2");  //second message scene
        }
        else {
          SceneManager.LoadScene("Lose");  // lose scene
        }
      }
    }
    
    public void clickNoise() {
      click.Play();
    }
}
