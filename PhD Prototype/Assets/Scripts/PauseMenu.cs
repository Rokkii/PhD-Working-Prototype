using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseMenu : MonoBehaviour
{
    public GameObject gameUI;
    public GameObject pauseUI;

    private bool gamePaused = false;    // Variable to declare if the game is paused or not, set default to false

    public static float gameSpeed = 1.0f;  // Set the speed of the game, initially 1.0, may increase due to player selections
    public static float pauseSpeed = 0.0f;  // Set default pause speed

    // Resume Game Function
    public void Resume()
    {
        gameUI.SetActive(true);         // Enable Game UI
        pauseUI.SetActive(false);       // Disable Pause UI
        Time.timeScale = gameSpeed + DifficultySetting.playerSelection;     // Apply Game speed
        gamePaused = true;
        print("Game Resumed! Game speed is: " + (gameSpeed + DifficultySetting.playerSelection));
    }

    // Pause Game Function
    public void Pause()
    {
        gameUI.SetActive(false);        // Disable Game UI
        pauseUI.SetActive(true);        // Enable Pause UI
        Time.timeScale = pauseSpeed;     // Disable Game speed
        gamePaused = false;
        print("Game Paused! Game speed is: " + pauseSpeed);
    }
}
