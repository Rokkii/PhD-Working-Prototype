using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PositionSelection : MonoBehaviour
{
    public string positionSelected = "None Selected";
    public string positionGroup = "None Selected";
    public static string displayString = "None";
    public static string positionGroupString = "None";
    public TMP_Text displayPosition;

    // Game Objects to enable/disable based on position
    public GameObject forwardUI;
    public GameObject backUI;

    // Start is called before the first frame update
    void Start()
    {
        displayPosition.text = displayString.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        displayPosition.text = displayString.ToString();
    }

    public void SetPosition()
    {
        displayString = positionSelected;
        positionGroupString = positionGroup;
        print(displayString + " position selected");
        print(positionGroupString + " positional group");
        displayPosition.text = displayString.ToString();
    }
}
