using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.AI;

public class npcMovement : MonoBehaviour
{
    // Set a target game object to move towards
    public GameObject objectMovingTo;

    // Set next targets, array so can allow as many targets as actions in a given scene
    public GameObject[] changeTargetObj;

    int actionCounter = 0;

    Animator npcAnimation;

    NavMeshAgent agent;

    public bool ballCarrier;

    public bool playerCrouched = false;

    // Set the movement speed of the NPC, set to 2.0 by default, changed in-client
    public float movementSpeed = 2.0f;

    // Gameobjects to change tags of
    public GameObject previousPlayer;
    public GameObject newPlayer;

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
            agent.SetDestination(objectMovingTo.transform.position);

            npcAnimation.SetFloat("Speed", agent.velocity.magnitude);

            npcAnimation.SetBool("BallCarrier", ballCarrier);
        }

        if (playerCrouched == true)
        {
            npcAnimation.SetBool("IsCrouched", true);
        }
    }

    // Do something when collides with target
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.transform.tag == "Tackler" && ballCarrier == true)
        {
            npcAnimation.SetBool("BeenTackled", true);
            print("You got tackled!");
            agent.isStopped = true;
        }
        if (collision.transform.tag == "TackleTarget")
        {
            npcAnimation.SetBool("MakeTackle", true);
            print("Tackle made!");
            agent.isStopped = true;
        }
        if (collision.gameObject == objectMovingTo)
        {
            print("Target reached by player");
            agent.isStopped = true;
        }
    }

    // If player chooses an action, change NPC movement target to a new gameobject
    public void ChangeTargets()
    {
        if (actionCounter != changeTargetObj.Length)
        {
            objectMovingTo = changeTargetObj[actionCounter];
            actionCounter++;
            print("Action taken! Changing target for: " + gameObject.name + " Adding to action counter, counter is now at: " + actionCounter);
        }
        else if (actionCounter == changeTargetObj.Length)
        {
            print("No new targets, set in inspector for: " + gameObject.name);
        }
    }

    // Change ball carrier when called, changing animation and where ball is
    public void ChangeBallCarrier()
    {
        if (ballCarrier == true)
        {
            ballCarrier = false;
            npcAnimation.SetBool("BallCarrier", ballCarrier);
        }
        else if (ballCarrier == false)
        {
            ballCarrier = true;
            npcAnimation.SetBool("BallCarrier", ballCarrier);
            newPlayer.tag = "TackleTarget";
            previousPlayer.tag = "NPCTarget";
        }

    }

    public void ResetBallCarrier()
    {
        ballCarrier = false;
        npcAnimation.SetBool("BallCarrier", ballCarrier);
    }

    // Stop NPC from moving by clearing target array
    public void StopMoving()
    {
        actionCounter = changeTargetObj.Length;
        objectMovingTo = null;
        agent.isStopped = true;
    }
}
