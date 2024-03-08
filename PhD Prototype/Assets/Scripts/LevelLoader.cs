using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelLoader : MonoBehaviour
{
    // Declare home scene
    public string homeScene;

    // Create array of scene names to load
    public string[] sceneList;

    // Create a static string to list all scenes selected (for debug panel)
    public static string sceneListString = "None Selected";

    // Create integer index of scene loaded to increment
    public static int gameSceneNumber = 0;

    // Load the next scene in the array when called
    public void LoadListedScenes()
    {
        // Reset scenes selected debug string
        sceneListString = "";

        // List each scene string for scenes selected
        for (int i = 0; i < sceneList.Length; i++)
        {
            sceneListString += sceneList[i] + "\n";
        }

        // Load the next scene on the array, if the counter hasn't reached the array length
        if (sceneList.Length > gameSceneNumber)
        {
            print("Loading next scene on the list! Loading: " + sceneList[gameSceneNumber]);
            SceneManager.LoadScene(sceneList[gameSceneNumber]);
            gameSceneNumber++;
        }
        // Reset the game scene counter if all scenes played, return to home scene
        else if (sceneList.Length <= gameSceneNumber)
        {
            print("List of scenes completed! Resetting scene counter and loading the home scene: " + homeScene);
            gameSceneNumber = 0;
            SceneManager.LoadScene(homeScene);
        }
    }

    public void ChangeScene(string loadLevelName)
    {
        SceneManager.LoadScene(loadLevelName);
    }
}
