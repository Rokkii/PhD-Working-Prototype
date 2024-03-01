using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class DifficultySetting : MonoBehaviour
{
    // Variables for game speed setting based on difficulty selection
    public static float noviceSpeed = 0f;
    public static float advancedSpeed = 0.25f;
    public static float expertSpeed = 0.5f;
    public static float playerSelection = 0.0f;

    public void NoviceSelection()
    {
        playerSelection = noviceSpeed;      // Set the player selection equal to value for setting
        print("Novice selected! Game speed is: " + (PauseMenu.gameSpeed + playerSelection));
        Time.timeScale = PauseMenu.gameSpeed + playerSelection;     // Apply Game speed
        print(Time.timeScale);
    }

    public void AdvancedSelection()
    {
        playerSelection = advancedSpeed;    // Set the player selection equal to value for setting
        print("Advanced selected! Game speed is: " + (PauseMenu.gameSpeed + playerSelection));
        Time.timeScale = PauseMenu.gameSpeed + playerSelection;     // Apply Game speed
    }

    public void ExpertSelection()
    {
        playerSelection = expertSpeed;      // Set the player selection equal to value for setting
        print("Expert selected! Game speed is: " + (PauseMenu.gameSpeed + playerSelection));
        Time.timeScale = PauseMenu.gameSpeed + playerSelection;     // Apply Game speed
    }
}
