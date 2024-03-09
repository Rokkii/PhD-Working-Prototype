using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class npcMovement : MonoBehaviour
{
    // Set a target game object to move towards
    public GameObject objectMovingTo;

    // Set the movement speed of the NPC, set to 2.0 by default, changed in-client
    public float movementSpeed = 2.0f;

    // Update is called once per frame
    void Update()
    {
        // If a target to move towards has been set, move towards it
        if (objectMovingTo != null)
        {
            transform.LookAt(objectMovingTo.transform);
            transform.position += transform.forward * movementSpeed * Time.deltaTime;
        }
    }

    // Do something when collides with target
    private void OnCollisionEnter(Collision collision)
    {
        print("You got tackled!");
        objectMovingTo = null;      // Stop moving when collided with
    }
}
