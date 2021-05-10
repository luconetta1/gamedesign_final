using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.EventSystems;

public class ChangeImage : MonoBehaviour
{
    public Sprite image1;
    public Sprite image2;
    public Sprite image3;
    public Sprite image4;
    
    // alternatives for images with hidden button
    public Sprite search;
    public Sprite shop;
    public Sprite home;
    public Sprite like;
    
    public Image post;
    
    private static int i;
    private static int postNum;
    private Sprite[] posts   = new Sprite[4];
    private string[] options = new string[]{"Search","Shop","Home","Like"};
    
    void Start() {  
      string currScene = SceneManager.GetActiveScene().name;
      if (currScene == "Instagram2") {
        Sprite[] pics1 = new Sprite[]{search,shop,home,like};
        Sprite[] pics2 = new Sprite[]{image1,image2,image3,image4};
      
        for (int j = 0; j < 4; j++) {
          if (i == j) {
            posts[j] = pics1[j];
          }
          else {
            posts[j] = pics2[j];
          }
        }
        
        post.sprite = posts[0];
        postNum = 1;
      }
    }
    
    public void setI() {
      i  = UnityEngine.Random.Range(0,options.Length);
    }
    
    public void nextImage() {
      if (postNum == 1) {
        post.sprite = posts[1];
        postNum = 2;
      }
      else if (postNum == 2) {
        post.sprite = posts[2];
        postNum = 3;
      }
      else if (postNum == 3) {
        post.sprite = posts[3];
        postNum = 4;
      }
      else if (postNum == 4) {
        post.sprite = posts[0];
        postNum = 1;
      }
    }
    
    public void lastImage() {
      if (postNum == 1) {
        post.sprite = posts[3];
        postNum = 4;
      }
      else if (postNum == 2) {
        post.sprite = posts[0];
        postNum = 1;
      }
      else if (postNum == 3) {
        post.sprite = posts[1];
        postNum = 2;
      }
      else if (postNum == 4) {
        post.sprite = posts[2];
        postNum = 3;
      }
    }
    
    public void nextScene() {
      if (EventSystem.current.currentSelectedGameObject.name == options[i]) {
          SceneManager.LoadScene("Message6");  //6th message
      }
      else {
        SceneManager.LoadScene("Lose");  // lose scene
      }
    
    }
}
