using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class Time: MonoBehaviour {
  
    private Text Clock;
    void Awake (){
        Clock = GetComponent<Text>();
    }
    void Update (){
        DateTime time = DateTime.Now;
        string hour = LeadingZero( time.Hour );
        string minute = LeadingZero( time.Minute );
        //Clock.text = hour + ":" + minute;
    }
    string LeadingZero (int n){
        return n.ToString().PadLeft(2, '0');
    }
}