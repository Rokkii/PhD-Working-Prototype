using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WASDMovement : MonoBehaviour
{

    public float playerSpeed = 10.0f;   // Declare player speed variable, set default speed

    Animator rugbyAnimation;

    private void Start()
    {
        rugbyAnimation = GetComponent<Animator>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        // If W pressed, move forward relative to player speed and in-game speed
        if (Input.GetKey(KeyCode.W))
        {
            transform.position += Vector3.forward * playerSpeed * Time.deltaTime;
            rugbyAnimation.SetFloat("Speed", playerSpeed);
        }
        // If W pressed, move back relative to player speed and in-game speed
        if (Input.GetKey(KeyCode.S))
        {
            transform.position += Vector3.back * playerSpeed * Time.deltaTime;
        }
        // If W pressed, move left relative to player speed and in-game speed
        if (Input.GetKey(KeyCode.A))
        {
            transform.position += Vector3.left * playerSpeed * Time.deltaTime;
        }
        // If W pressed, move right relative to player speed and in-game speed
        if (Input.GetKey(KeyCode.D))
        {
            transform.position += Vector3.right * playerSpeed * Time.deltaTime;
        }
        else if (Input.anyKeyDown == false)
        {
            rugbyAnimation.SetFloat("Speed", 0);
        }
    }
}
