using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeCameraPause : MonoBehaviour
{
    public float gameSpeed = 1.0f;
    public float pauseTime = 5.0f;

    public GameObject[] disableList;
    public GameObject[] enableList;
    public GameObject defaultCamera;

    // Start is called before the first frame update
    void Start()
    {
        gameSpeed = DifficultySetting.playerSpeedSelection;
    }

    // Start coroutine when script started
    public void StartCameraPause()
    {
        StartCoroutine(CameraChangePause(pauseTime));
    }

    public IEnumerator CameraChangePause(float pauseTime)
    {
        print("Starting camera pause of: " + pauseTime + " seconds");
        Time.timeScale = 0f;
        float pauseEndTime = Time.realtimeSinceStartup + pauseTime;

        // While time since scene start up is less than pause time, keep game speed = 0
        while (Time.realtimeSinceStartup < pauseEndTime)
        {
            yield return 0;
        }

        // Reset game speed
        Time.timeScale = gameSpeed;
        print("Pause finished, resetting camera and setting game speed to: " + gameSpeed);

        // Enable/Disable array of gameobjects
        foreach(GameObject disableObjects in disableList)
            disableObjects.SetActive(false);
        foreach (GameObject enableObjects in enableList)
            enableObjects.SetActive(true);
    }

    // Reset Game World Speed when called
    public void ResetGameWorldSpeed()
    {
        Time.timeScale = gameSpeed;
        print("Game Speed now: " + Time.timeScale);
    }
}
