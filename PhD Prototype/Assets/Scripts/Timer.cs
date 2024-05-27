using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Timer : MonoBehaviour
{
    // Create text object in-game to display timer
    public TMP_Text timer;

    // Set default timer time (10 secs)
    public float timeRemaining = 10.0f;

    // Declare a time elapsed variable
    public float timeGone = 0.0f;

    // Bool to declare if timer is active, default false (set in-client)
    public bool timerActive = false;

    // Declare bool for if timer has expired
    public bool timerExpired = false;

    // Set a variable for if a timer is for a question, by default false (set in-client)
    public bool questionTimer = false;

    // Declare public game object, to control when to activate (deactivate by default)
    public GameObject questionUI;

    public GameObject[] disableUITimeExpired;

    // Update is called once per frame
    void Update()
    {
        if (timerActive == true && timeRemaining >= 0)
        {
            timeRemaining -= 1 * Time.deltaTime;
            if (timer != null)
                timer.text = timeRemaining.ToString("0.0");
        }
        else if (timerActive == true && timerExpired == false)
        {
            TimeOut();
        }
    }

    // Called when timer reaches 0 time remaining
    public void TimeOut()
    {
        print("You ran out of time!");
        timerExpired = true;

        // If game scene is a question scene, timer will show question after set time
        if (questionTimer == true)
        {
            QuestionTimer();
        }
    }

    // Reset timer if called
    public void ResetTimer()
    {
        timeRemaining = 10.0f;
        timerExpired = false;
        print("Resetting timer! Countdown will restart");
    }


    // Display a question/UI if timer is to show this after set time
    public void QuestionTimer()
    {
        print("This was a question timer!");
        questionUI.SetActive(true);
        Time.timeScale = 0.0f;
    }

    // Start a wait timer if player made a choice to trigger game UI
    public void waitTimer()
    {
        timerActive = true;
        foreach (GameObject disableUI in disableUITimeExpired)
            disableUI.SetActive(false);
    }

}
