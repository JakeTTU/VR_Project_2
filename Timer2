
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Timer : MonoBehaviour {
 
 public Text timerText;
     bool keepTiming;
     	float currentTime = 0f;

     void Start () {
         StartTimer();
     }
 
     void Update () {
       
 
         if(keepTiming){
             UpdateTime();
         }
     }
 
     void UpdateTime(){
         currentTime += 1 * Time.deltaTime;
         timerText.text = TimeToString(currentTime);
     }
 
     float StopTimer(){
         keepTiming = false;
         return currentTime;
     }
 

 
     void StartTimer(){
         keepTiming = true;
     }
 
     string TimeToString(float t){

         string minutes = ((int) t / 60).ToString();
         //string seconds = (t % 60 ).ToString("f2");
         string seconds = (t % 60 ).ToString("0");
         return minutes + ":" + seconds;
     }
 
 }
