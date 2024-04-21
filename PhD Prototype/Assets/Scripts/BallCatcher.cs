using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallCatcher : MonoBehaviour
{
    public Transform BallHoldingPosition;

    public Transform BallTransofmrm;

    public Transform target;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            BallTransofmrm.parent = BallHoldingPosition;
            BallTransofmrm.localPosition = Vector3.zero;
            BallTransofmrm.localEulerAngles = Vector3.zero;
        }

        if (Input.GetKeyDown(KeyCode.P))
        {
            BallTransofmrm.parent = null;
        }

        if(Input.GetKeyDown(KeyCode.X))
        {
            MoveBall(target.position);
        }
    }


    void MoveBall(Vector3 targetpos)
    {
        Rigidbody ballRgbd = BallTransofmrm.GetComponent<Rigidbody>();

        Vector3 dir = (targetpos - BallTransofmrm.position).normalized;

        ballRgbd.velocity = dir * 5;
    }
}
