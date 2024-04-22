using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallCatcher : MonoBehaviour
{
    public Transform BallHoldingPosition;

    public Transform BallTransform;

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
            MoveBall(target.position);
        }
    }


    void MoveBall(Vector3 targetpos)
    {
        Rigidbody ballRgbd = BallTransform.GetComponent<Rigidbody>();

        Vector3 dir = (targetpos - BallTransform.position).normalized;

        ballRgbd.velocity = dir * 5;
    }
}
