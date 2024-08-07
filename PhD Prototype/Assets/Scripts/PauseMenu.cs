using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseMenu : MonoBehaviour
{
    public GameObject gameUI;
    public GameObject pauseUI;

    public static float gameSpeed = 1.0f;  // Set the speed of the game, initially 1.0, may increase due to player selections
    public static float pauseSpeed = 0.0f;  // Set default pause speed

    // Resume Game Function
    public void Resume()
    {
        gameUI.SetActive(true);         // Enable Game UI
        pauseUI.SetActive(false);       // Disable Pause UI
        Time.timeScale = gameSpeed + DifficultySetting.playerSpeedSelection;     // Apply Game speed
        print("Game Resumed! Game speed is: " + (gameSpeed + DifficultySetting.playerSpeedSelection));
    }

    // Pause Game Function
    public void Pause()
    {
        gameUI.SetActive(false);            // Disable Game UI
        pauseUI.SetActive(true);            // Enable Pause UI
        Time.timeScale = pauseSpeed;        // Disable Game speed
        print("Game Paused! Game speed is: " + pauseSpeed);
    }

    // Exit the game when called
    public void ExitGame()
    {
        Time.timeScale = 1.0f;
        print("Closing the game! Game speed reset to: " + Time.timeScale);
        Application.Quit();
    }
}
