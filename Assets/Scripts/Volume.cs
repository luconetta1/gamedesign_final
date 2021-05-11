using UnityEngine;
using System.Collections;
using UnityEngine.Audio; 

public class Volume : MonoBehaviour{

 public AudioMixer mix;

 public void SetLevel (float slideVal){
    mix.SetFloat("MusicVolume", Mathf.Log10 (slideVal) * 20);
 }
}