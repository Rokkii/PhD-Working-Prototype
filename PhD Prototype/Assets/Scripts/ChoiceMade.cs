using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChoiceMade : MonoBehaviour
{
    public GameObject[] cameraList;

    public GameObject newPlayer;

    public void SwitchPlayer()
    {
        foreach (GameObject camerasToMove in cameraList)
        {
            camerasToMove.transform.parent = newPlayer.transform;
            camerasToMove.transform.position = new Vector3(0, 2, -3);
        }
    }
}
