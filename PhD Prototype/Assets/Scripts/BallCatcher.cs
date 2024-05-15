using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallCatcher : MonoBehaviour
{
    public Transform BallHoldingPosition;

    public Transform BallTransform;

    public Transform target;

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
        if (Input.GetKeyDown(KeyCode.Space))
        {
            BallTransform.parent = BallHoldingPosition;
            BallTransform.localPosition = Vector3.zero;
            BallTransform.localEulerAngles = Vector3.zero;
        }

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
        if (Input.GetKeyDown(KeyCode.C))
        {
            if (HoldingBall)
            {
                ballBehaviour.Target = target;
                ballBehaviour.passed = true;
            }
        }
    }

    void PassBall(Vector3 Target)
    {

    }

    // Moves ball with target requirement
    void MoveBall(Vector3 targetpos)
    {
        Rigidbody ballRgbd = BallTransform.GetComponent<Rigidbody>();

        Vector3 dir = (targetpos - BallTransform.position).normalized;

        ballRgbd.velocity = dir * 5;
    }
}
