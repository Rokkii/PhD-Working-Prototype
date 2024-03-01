using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ScoreBoard : MonoBehaviour
{
    public static float playerScore = 0;
    public TMP_Text scoreBoardText;
    public float pointsAdded = 5.0f;

    // Reset the player score to 0, possibly at the beginning of a new game
    public void ResetScore()
    {
        playerScore = 0;
        print("Score reset! Player score is now: " + playerScore);
        scoreBoardText.text = playerScore.ToString("0");     // Outputs score as a text string
    }

    // Add points to the players score (test)
    public void AddScore()
    {
        playerScore += pointsAdded;
        print("Score Added! New score is: " + playerScore);
        scoreBoardText.text = playerScore.ToString("0");     // Outputs score as a text string
    }
}
