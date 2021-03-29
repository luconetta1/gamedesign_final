using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.UI;
using System;

public class Clock: MonoBehaviour {
  
    private Text timeClock;
    void Start (){
        timeClock = GetComponent<Text>();
    }
    void Update (){
        DateTime time = DateTime.Now;
        int hour =time.Hour;
        if( hour > 12){
            hour = hour - 12;
        }
        string hour_fin =hour.ToString() ;
        string minute = LeadingZero( time.Minute );
        //Console.Error.WriteLine(Clock.text);
        timeClock.text = hour_fin + ":" + minute;
    }
    string LeadingZero (int n){
        return n.ToString().PadLeft(2, '0');
    }
}