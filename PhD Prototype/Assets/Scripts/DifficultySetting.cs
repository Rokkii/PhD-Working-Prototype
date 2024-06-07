using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class DifficultySetting : MonoBehaviour
{
    // Variables for game speed setting based on difficulty selection
    public static float defaultSpeed = 0f;
    public static float noviceSpeed = 0f;
    public static float advancedSpeed = 0.25f;
    public static float expertSpeed = 0.5f;
    public static float playerSpeedSelection = 1.0f;

    // Variables for difficulty score multipliers
    public static float defaultScore = 1.0f;
    public static float noviceScore = 1.0f;
    public static float advancedScore = 1.5f;
    public static float expertScore = 2.0f;
    public static float playerScoringSelection = 1.0f;  // Set player score multipler to 1.0 by default

    public static string difficultyChoice = "Default";

    public void NoviceSelection()
    {
        difficultyChoice = "Novice";    // Set string difficulty value
        playerSpeedSelection = noviceSpeed;      // Set the player selection equal to value for setting
        print("Novice selected! Game speed is: " + (PauseMenu.gameSpeed + playerSpeedSelection));
        Time.timeScale = PauseMenu.gameSpeed + playerSpeedSelection;     // Apply Game speed
        print(Time.timeScale);
        playerScoringSelection = noviceScore;   // Set player's selection equal to scoring difficulty multiplier
        print("Novice difficulty, score multipler is: " + playerScoringSelection);
    }

    public void AdvancedSelection()
    {
        difficultyChoice = "Advanced";    // Set string difficulty value
        playerSpeedSelection = advancedSpeed;    // Set the player selection equal to value for setting
        print("Advanced selected! Game speed is: " + (PauseMenu.gameSpeed + playerSpeedSelection));
        Time.timeScale = PauseMenu.gameSpeed + playerSpeedSelection;     // Apply Game speed
        playerScoringSelection = advancedScore;   // Set player's selection equal to scoring difficulty multiplier
        print("Advanced difficulty, score multipler is: " + playerScoringSelection);
    }

    public void ExpertSelection()
    {
        difficultyChoice = "Expert";    // Set string difficulty value
        playerSpeedSelection = expertSpeed;      // Set the player selection equal to value for setting
        print("Expert selected! Game speed is: " + (PauseMenu.gameSpeed + playerSpeedSelection));
        Time.timeScale = PauseMenu.gameSpeed + playerSpeedSelection;     // Apply Game speed
        playerScoringSelection = expertScore;   // Set player's selection equal to scoring difficulty multiplier
        print("Expert difficulty, score multipler is: " + playerScoringSelection);
    }

    public void ResetDifficultySettings()
    {
        difficultyChoice = "Default";
        playerSpeedSelection = defaultSpeed;
        Time.timeScale = playerSpeedSelection;
        playerScoringSelection = defaultScore;
    }
}
