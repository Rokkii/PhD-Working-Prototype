using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnimationController : MonoBehaviour
{
    Animator rugbyAnimation;
    Rigidbody rgbd;

    // Start is called before the first frame update
    void Start()
    {
        rugbyAnimation = GetComponent<Animator>();
        rgbd = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");

        rgbd.velocity = v * 10 * transform.forward;

        transform.Rotate(h * transform.up);

        rugbyAnimation.SetFloat("Speed", rgbd.velocity.magnitude);
    }
}
