using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.AI;

public class npcMovement : MonoBehaviour
{
    // Set a target game object to move towards
    public GameObject objectMovingTo;
    public GameObject changeTargetObj;

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
            agent.SetDestination(objectMovingTo.transform.position);

            npcAnimation.SetFloat("Speed", agent.velocity.magnitude);

            npcAnimation.SetBool("BallCarrier", ballCarrier);
        }
    }

    // Do something when collides with target
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.transform.tag == "Tackler")
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
        objectMovingTo = changeTargetObj;
    }
}
