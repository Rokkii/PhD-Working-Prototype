using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraSwitcher : MonoBehaviour
{
    public GameObject[] disableObjectsList;

    public GameObject cameraChosen;

    public GameObject[] enableUIButtons;

    public GameObject buttonToHide;

    public void CameraSwitch()
    {
        // Disable cameras in object array
        foreach (GameObject deactivateObject in disableObjectsList)
        {
            deactivateObject.SetActive(false);
        }

        cameraChosen.SetActive(true);
        print("Camera change selected! Changing to: " + cameraChosen);

        // Enable all UI buttons in object array
        foreach (GameObject activateObject in enableUIButtons)
        {
            activateObject.SetActive(true);
        }

        buttonToHide.SetActive(false);
        print("Camera change selected! Disabling button: " + buttonToHide.name);
    }
}
