using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

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
    public static string positionChoice = "Default";

    // Public game text objects to display in menus
    public TMP_Text difficultyText;
    public TMP_Text positionText;

    void Update()
    {
        difficultyText.text = difficultyChoice.ToString();
    }

    public void BeginnerSelection()
    {
        difficultyChoice = "Beginner";    // Set string difficulty value
        playerSpeedSelection = noviceSpeed;      // Set the player selection equal to value for setting
        print(difficultyChoice + " selected! Game speed is: " + (PauseMenu.gameSpeed + playerSpeedSelection));
        Time.timeScale = PauseMenu.gameSpeed + playerSpeedSelection;     // Apply Game speed
        print(Time.timeScale);
        playerScoringSelection = noviceScore;   // Set player's selection equal to scoring difficulty multiplier
        print(difficultyChoice + " difficulty, score multipler is: " + playerScoringSelection);
        difficultyText.text = difficultyChoice.ToString();
    }

    public void ExperiencedSelection()
    {
        difficultyChoice = "Experienced";    // Set string difficulty value
        playerSpeedSelection = advancedSpeed;    // Set the player selection equal to value for setting
        print(difficultyChoice + " selected! Game speed is: " + (PauseMenu.gameSpeed + playerSpeedSelection));
        Time.timeScale = PauseMenu.gameSpeed + playerSpeedSelection;     // Apply Game speed
        playerScoringSelection = advancedScore;   // Set player's selection equal to scoring difficulty multiplier
        print(difficultyChoice + " difficulty, score multipler is: " + playerScoringSelection);
        difficultyText.text = difficultyChoice.ToString();
    }

    public void AdvancedSelection()
    {
        difficultyChoice = "Advanced";    // Set string difficulty value
        playerSpeedSelection = expertSpeed;      // Set the player selection equal to value for setting
        print(difficultyChoice + " selected! Game speed is: " + (PauseMenu.gameSpeed + playerSpeedSelection));
        Time.timeScale = PauseMenu.gameSpeed + playerSpeedSelection;     // Apply Game speed
        playerScoringSelection = expertScore;   // Set player's selection equal to scoring difficulty multiplier
        print(difficultyChoice + " difficulty, score multipler is: " + playerScoringSelection);
        difficultyText.text = difficultyChoice.ToString();
    }

    public void ResetDifficultySettings()
    {
        difficultyChoice = "Default";
        playerSpeedSelection = defaultSpeed;
        Time.timeScale = playerSpeedSelection;
        playerScoringSelection = defaultScore;
    }
}
