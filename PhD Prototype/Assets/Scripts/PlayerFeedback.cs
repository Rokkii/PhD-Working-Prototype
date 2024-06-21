using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PlayerFeedback : MonoBehaviour
{
    public bool addFeedback = false;            // bool to check if at the end of the scene to add player feedback, set default to false
    public TMP_Text feedbackDisplay;            // Game text object to display player feedback
    public string sceneFeedback;                // String for specific feedback set in-client

    public bool addPlayerAction = true;
    public TMP_Text actionDisplay;
    public string playerAction;

    public static string finalFeedbackString = "No Feedback Yet";
    public static string finalActionString = "No Actions Yet";

    // If the scene conclusion has feedback assigned, add it to the player's feedback array
    public void AddPlayerFeedback()
    {
        // If final feedback string is not default, just add next feedback element
        if (finalFeedbackString != "No Feedback Yet" && addFeedback == true)
        {
            finalFeedbackString += sceneFeedback + "\n";
            print("Adding feedback: " + sceneFeedback);
        }
        // If final feedback string is set to default, clear and add initial feedback element
        if (finalFeedbackString == "No Feedback Yet" && addFeedback == true)
        {
            finalFeedbackString = "";
            print("No Feedback detected, clearing string");
            finalFeedbackString += sceneFeedback + "\n";
            print("Adding feedback: " + sceneFeedback);
        }
    }

    // If the scene conclusion has feedback assigned, add player choice to actions
    public void AddPlayerAction()
    {
        // If final feedback string is not default, just add next feedback element
        if (finalActionString != "No Actions Yet" && addPlayerAction == true)
        {
            finalActionString += playerAction + "\n";
            print("Adding feedback: " + playerAction);
        }
        // If final feedback string is set to default, clear and add initial feedback element
        if (finalActionString == "No Actions Yet" && addPlayerAction == true)
        {
            finalActionString = "";
            print("No Feedback detected, clearing string");
            finalActionString += playerAction + "\n";
            print("Adding feedback: " + playerAction);
        }
    }

    // Show all generated player feedback on the in-client game text object
    public void ShowFeedback()
    {
        feedbackDisplay.text = finalFeedbackString.ToString();
    }

    // Show all generated player actions on the in-client game text object
    public void ShowActions()
    {
        actionDisplay.text = finalActionString.ToString();
    }

    // Reset player feedback array when called
    public void ResetPlayerFeedback()
    {
        finalFeedbackString = "No Feedback Yet";
    }
}
