using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.AI;

public class npcMovement : MonoBehaviour
{
    // Set a target game object to move towards
    public GameObject objectMovingTo;

    Animator npcAnimation;

    NavMeshAgent agent;

    public bool ballCarrier;

    // Set the movement speed of the NPC, set to 2.0 by default, changed in-client
    public float movementSpeed = 2.0f;

    // Start is called before the first frame update
    void Start()
    {
        npcAnimation = GetComponent<Animator>();
        agent = GetComponent<NavMeshAgent>();
    }

    // Update is called once per frame
    void Update()
    {
        // If a target to move towards has been set, move towards it
        if (objectMovingTo != null)
        {
            /*
            transform.LookAt(objectMovingTo.transform);
            transform.position += transform.forward * movementSpeed * Time.deltaTime;
            npcAnimation.SetFloat("Speed", movementSpeed * Time.deltaTime);
            */

            agent.SetDestination(objectMovingTo.transform.position);
        }

        npcAnimation.SetFloat("Speed", agent.velocity.magnitude);

        npcAnimation.SetBool("BallCarrier", ballCarrier);
    }

    // Do something when collides with target
    private void OnCollisionEnter(Collision collision)
    {
        print("You got tackled!");
        objectMovingTo = null;      // Stop moving when collided with
    }
}
