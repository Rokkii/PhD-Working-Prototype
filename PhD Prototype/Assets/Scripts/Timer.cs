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

    void Start()
    {
        timer.GetComponent<Text>().text = timeRemaining.ToString("0.0");
    }

    // Update is called once per frame
    void Update()
    {
        if (timeRemaining >= 0)
        {
            timeRemaining -= 1 * Time.deltaTime;
            timer.GetComponent<Text>().text = timeRemaining.ToString("0.0");
        }
        else
        {
            TimeOut();
        }
    }

    public void TimeOut()
    {
        print("You ran out of time!");
        ResetTimer();
    }

    public void ResetTimer()
    {
        timeRemaining = 10.0f;
    }

}
