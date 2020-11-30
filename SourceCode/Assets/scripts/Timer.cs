
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Timer : MonoBehaviour
{

    public Text timerText;
    bool keepTiming;
    float currentTime = 0f;

    void Start()
    {
        StartTimer();
    }

    void Update()
    {
        bool isFinished = CheckGameStatus();

        if (isFinished)
        {
            StopTimer();
            return;
        }

         keepTiming = CameraPosition.gameStart;
       
        if (keepTiming)
        {
            UpdateTime();
        }
    }

    bool CheckGameStatus()
    {
        bool isFinished;
        GameObject[] objs = GameObject.FindGameObjectsWithTag(CameraPosition.level);
        print("objs:" + objs);
        foreach (GameObject obj in objs)
        {
            if (obj.GetComponent<SnapToLocation>().Snapped == false)
            {
                isFinished = false;
                return isFinished;
            }
            else
            {
                print("TRUE");
            }

        }

        isFinished = true;
        CameraPosition.gameStart = false;
        CameraPosition.restartGame = false;
        print("isFinished:" + isFinished);
        return isFinished;
    }

    void UpdateTime()
    {
        if (CameraPosition.restartGame)
        {
            currentTime = 0f;
            CameraPosition.restartGame = false; 
        }
        else
        {
            currentTime += 1 * Time.deltaTime;
        }
        
        timerText.text = TimeToString(currentTime);
    }

    float StopTimer()
    {
        keepTiming = false;
        return currentTime;
    }



    void StartTimer()
    {
        keepTiming = true;
    }

    string TimeToString(float t)
    {

        string minutes = ((int)t / 60).ToString();
        //string seconds = (t % 60 ).ToString("f2");
        string seconds = (t % 60).ToString("0");
        return minutes + ":" + seconds;
    }

}
