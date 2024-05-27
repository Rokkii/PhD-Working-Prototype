using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallCatcher : MonoBehaviour
{
    public Transform BallHoldingPosition;

    public Transform BallTransform;

    public Transform target;

    public Transform passLeftTarget;
    public Transform passRightTarget;
    public Transform kickTarget;

    public GameObject player;

    public bool HoldingBall = false;

    npcMovement npc;
    BallBehaviour ballBehaviour;

    // Start is called before the first frame update
    void Start()
    {
        npc = GetComponent<npcMovement>();
        HoldingBall = npc.ballCarrier;
        if (BallTransform != null)
            ballBehaviour = BallTransform.GetComponent<BallBehaviour>();
        
    }

    // Update is called once per frame
    void Update()
    {
        HoldingBall = npc.ballCarrier;

        // Catching a ball - should go in oncollisionenter
        if (Input.GetKeyDown(KeyCode.Space))
        {
            BallTransform.parent = BallHoldingPosition;
            BallTransform.localPosition = Vector3.zero;
            BallTransform.localEulerAngles = Vector3.zero;
        }

        // Dropping a ball
        if (Input.GetKeyDown(KeyCode.P))
        {
            BallTransform.parent = null;
        }

        if(Input.GetKeyDown(KeyCode.X))
        {
            if (HoldingBall)
            {
                MoveBall(target.position);
            }
        }

        // Passing the ball to a target
        if (Input.GetKeyDown(KeyCode.C))
        {
            // pass ball, can make public method
            if (HoldingBall)
            {
                ballBehaviour.Target = target;
                ballBehaviour.passed = true;
            }
        }
    }

    // Moves ball with target requirement
    void MoveBall(Vector3 targetpos)
    {
        Rigidbody ballRgbd = BallTransform.GetComponent<Rigidbody>();

        Vector3 dir = (targetpos - BallTransform.position).normalized;

        ballRgbd.velocity = dir * 5;
    }

    public void PassLeft()
    {
        // pass ball, can make public method
        if (HoldingBall)
        {
            target = passLeftTarget;
            ballBehaviour.Target = target;
            ballBehaviour.passed = true;
        }
    }

    public void PassRight()
    {
        // pass ball, can make public method
        if (HoldingBall)
        {
            target = passRightTarget;
            ballBehaviour.Target = target;
            ballBehaviour.passed = true;
        }
    }

    public void Kick()
    {
        // pass ball, can make public method
        if (HoldingBall)
        {
            target = kickTarget;
            ballBehaviour.Target = target;
            ballBehaviour.passed = true;
            BallTransform.parent = target;
            player.tag = "NPCTarget";
        }
    }
}
