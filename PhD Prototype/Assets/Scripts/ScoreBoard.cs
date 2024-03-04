using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ScoreBoard : MonoBehaviour
{
    public static float playerScore = 0;
    public TMP_Text scoreBoardText;
    public float pointsAdded = 10.0f;

    // Variables for multiple choice option scoring, set defaults but can be set per scene
    public float goodScore = 100.0f;
    public float okScore = 50.0f;
    public float badScore = 10.0f;

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
        playerScore += (pointsAdded * DifficultySetting.playerScoringSelection);
        print("Score Added! New score is: " + playerScore);
        print("Points added where: " + pointsAdded + " multiplied by difficulty of: " + DifficultySetting.playerScoringSelection);
        scoreBoardText.text = playerScore.ToString("0");     // Outputs score as a text string
    }

    // Award points based on players choice - multiple choice selection questions
    public void ScoreOnSelection(Button playerChoice)
    {
        if (playerChoice.gameObject.tag == "GoodChoice")
        {
            playerScore += (goodScore * DifficultySetting.playerScoringSelection);
            print("Good choice! Adding points: " + goodScore + " multiplied by " + DifficultySetting.playerScoringSelection);
            scoreBoardText.text = playerScore.ToString("0");     // Outputs score as a text string
        }
        else if (playerChoice.gameObject.tag == "OkChoice")
        {
            playerScore += (okScore * DifficultySetting.playerScoringSelection);
            print("OK choice! Adding points: " + okScore + " multiplied by " + DifficultySetting.playerScoringSelection);
            scoreBoardText.text = playerScore.ToString("0");     // Outputs score as a text string
        }
        else if (playerChoice.gameObject.tag == "BadChoice")
        {
            playerScore += (badScore * DifficultySetting.playerScoringSelection);
            print("Bad choice! Adding points: " + badScore + " multiplied by " + DifficultySetting.playerScoringSelection);
            scoreBoardText.text = playerScore.ToString("0");     // Outputs score as a text string
        }
    }
}
