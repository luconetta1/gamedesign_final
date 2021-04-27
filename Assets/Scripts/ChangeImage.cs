using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChangeImage : MonoBehaviour
{
    public Sprite image1;
    public Sprite image2;
    public Sprite image3;
    public Sprite image4;
    public Image post;
    
    private static int postNum;
    
    void Start() {
      post.sprite = image1;
      postNum = 1;
    }
    
    public void nextImage() {
      if (postNum == 1) {
        post.sprite = image2;
        postNum = 2;
      }
      else if (postNum == 2) {
        post.sprite = image3;
        postNum = 3;
      }
      else if (postNum == 3) {
        post.sprite = image4;
        postNum = 4;
      }
      else if (postNum == 4) {
        post.sprite = image1;
        postNum = 1;
      }
    }
    
    public void lastImage() {
      if (postNum == 1) {
        post.sprite = image4;
        postNum = 4;
      }
      else if (postNum == 2) {
        post.sprite = image1;
        postNum = 1;
      }
      else if (postNum == 3) {
        post.sprite = image2;
        postNum = 2;
      }
      else if (postNum == 4) {
        post.sprite = image3;
        postNum = 3;
      }
    }
}
