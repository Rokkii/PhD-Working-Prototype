using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class DebugMenu : MonoBehaviour
{
    // Create text variables to output to debug panel text objects
    public TMP_Text debugPlayerScore;
    public TMP_Text debugGameSpeed;
    public TMP_Text debugActualSpeed;
    public TMP_Text debugScenesPlayed;
    public TMP_Text debugDifficulty;
    public TMP_Text debugScoreMultiplier;
    public TMP_Text debugScenesToLoad;
    public TMP_Text debugPlayerFeedback;

    // Update is called once per frame
    void Update()
    {
        debugPlayerScore.text = ScoreBoard.playerScore.ToString("0");                                               // Outputs score as a text string
        debugGameSpeed.text = (PauseMenu.gameSpeed + DifficultySetting.playerSpeedSelection).ToString("0.00");      // Outputs game speed as a text string
        debugActualSpeed.text = Time.timeScale.ToString("0.00");                                                    // Outputs actual game speed (from engine) as a text string
        debugScenesPlayed.text = LevelLoader.gameSceneNumber.ToString("0");                                         // Outputs scenes played as a text string
        debugDifficulty.text = DifficultySetting.difficultyChoice.ToString();                                       // Outputs difficulty choice as a text string
        debugScoreMultiplier.text = DifficultySetting.playerScoringSelection.ToString("0.0");                       // Outputs player score multiplier as a text string
        debugScenesToLoad.text = LevelLoader.sceneListString.ToString();                                            // Outputs scenes selected by the player as a string
        debugPlayerFeedback.text = PlayerFeedback.finalFeedbackString.ToString();
    }
}
