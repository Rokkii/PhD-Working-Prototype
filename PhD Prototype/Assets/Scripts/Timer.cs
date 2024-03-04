using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Timer : MonoBehaviour
{
    public TMP_Text timer;
    public float timeRemaining = 10.0f;
    public float timeGone = 0.0f;
    public bool timerExpired = false;

    // Update is called once per frame
    void Update()
    {
        if (timeRemaining >= 0)
        {
            timeRemaining -= 1 * Time.deltaTime;
            timer.text = timeRemaining.ToString("0.0");
        }
        else if (timerExpired == false)
        {
            TimeOut();
        }
    }

    public void TimeOut()
    {
        print("You ran out of time!");
        timerExpired = true;
    }

    public void ResetTimer()
    {
        timeRemaining = 10.0f;
        timerExpired = false;
        print("Resetting timer! Countdown will restart");
    }

}
