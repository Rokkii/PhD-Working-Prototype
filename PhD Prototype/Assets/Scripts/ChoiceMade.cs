using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChoiceMade : MonoBehaviour
{
    public GameObject[] cameraList;

    public GameObject newPlayer;

    // Active Cameras
    public GameObject lookForward;
    public GameObject lookLeft;
    public GameObject lookRight;
    public GameObject overheadCam;

    // Dummy Cameras to take position from
    public GameObject dummyLookForward;
    public GameObject dummyLookLeft;
    public GameObject dummyLookRight;
    public GameObject dummyOverheadCam;

    // Array of objects to disable when a choice is made
    public GameObject[] disableObjects;

    // Array of objects to enable when a choice is made
    public GameObject[] enableObjects;

    public void PlayerMadeDecision()
    {
        // Set all active cameras to child of new player
        foreach (GameObject camerasToMove in cameraList)
        {
            camerasToMove.transform.parent = newPlayer.transform;
        }

        if (cameraList.Length != 0)
        {
            print("Choice made, cameras set to change with choice");

            // Set new camera positions based on position of dummy cameras on new player
            lookForward.transform.position = dummyLookForward.transform.position;
            lookLeft.transform.position = dummyLookLeft.transform.position;
            lookRight.transform.position = dummyLookRight.transform.position;
            overheadCam.transform.position = dummyOverheadCam.transform.position;
        }
        else if (cameraList.Length == 0)
        {
            print("Choice made, no cameras to change");
        }

        // Disable objects from choice
        foreach (GameObject objectDsiable in disableObjects)
        {
            objectDsiable.SetActive(false);
        }

        // Enable objects from choice
        foreach (GameObject objectEnable in enableObjects)
        {
            objectEnable.SetActive(true);
        }
    }
}
