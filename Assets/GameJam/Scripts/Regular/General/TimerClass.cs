﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

namespace Assets.GameJam.Scripts.Regular.General
{
    public class TimerClass
    {
        public bool isTimerRunning = false;
        private float timeElapsed = 0.0f;
        private float currentTime = 0.0f;
        private float lastTime = 0.0f;
        private float timeScaleFactor = 1.1f; // Change this to scale the time.

        private string timeString;
        private string hour;
        private string minutes;
        private string seconds;
        private string mills;

        private int aHour;
        private int aMinute;
        private int aSecond;
        private int aMillis;
        private int tmp;
        private int aTime;

        private GameObject callback;


        public void UpdateTimer()
        {
            // calculate the time elapsed since the last Update();
            timeElapsed = Mathf.Abs(Time.realtimeSinceStartup - lastTime);
            
            // if the timer is running, we add the time elapsed to the current time (advancing the timer)
            if(isTimerRunning)
            {
                currentTime += timeElapsed * timeScaleFactor;
            }

            // store the current time so that we can use it on the next update.
            lastTime = Time.realtimeSinceStartup;
        }
        
        public void StartTimer()
        {
            // set up initial variables to start the timer.
            isTimerRunning = true;
            lastTime = Time.realtimeSinceStartup;
        }

        public void StopTimer()
        {
            // stop the timer
            isTimerRunning = false;
        }

        public void ResetTimer()
        {
            // resetTimer will set the timer back to zero.
            timeElapsed = 0.0f;
            currentTime = 0.0f;
            lastTime = Time.realtimeSinceStartup;
        }

        public string GetFormattedTime()
        {
            // carry out an update to the timer so it's 'up to date'
            UpdateTimer();
            
            // grab minutes
            aMinute = (int)currentTime / 60;
            aMinute = aMinute % 60;

            // grab seconds
            aSecond = (int)currentTime % 60;

            // grab miliseconds
            aMillis = (int)(currentTime * 100) % 100;

            // format strings for individual mm/ss/mills
            tmp = (int)aSecond;
            seconds = tmp.ToString();
            if (seconds.Length < 2)
                seconds = "0" + seconds;

            tmp = (int)aMinute;
            minutes = tmp.ToString();
            if (minutes.Length < 2)
                minutes = "0" + minutes;

            tmp = (int)aMillis;
            mills = tmp.ToString();
            if (minutes.Length < 2)
                mills = "0" + mills;

            // pull together a formatted string to return
            timeString = minutes + ":" + seconds + ":" + mills;


            return timeString;
        }

        public int GetTime()
        {
            // remember to call UpdateTimer() before trying to use this function, otherwise the time value will not be up to date.
            UpdateTimer();
            return (int)currentTime;
        }
    }
}
