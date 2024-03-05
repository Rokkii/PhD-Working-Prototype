using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraSwitcher : MonoBehaviour
{
    public GameObject[] disableObjectsList;

    public GameObject cameraChosen;

    public void CameraSwitch()
    {
        foreach (GameObject deactivateObject in disableObjectsList)
        {
            deactivateObject.SetActive(false);
        }

        cameraChosen.SetActive(true);
        print("Camera change selected! Changing to: " + cameraChosen);
    }
}
