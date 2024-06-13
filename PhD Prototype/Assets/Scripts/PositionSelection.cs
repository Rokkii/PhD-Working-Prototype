using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PositionSelection : MonoBehaviour
{
    public string positionSelected = "None Selected";
    public static string displayString = "None";
    public TMP_Text displayPosition;

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
        print(displayString + " position selected");
        displayPosition.text = displayString.ToString();
    }
}
