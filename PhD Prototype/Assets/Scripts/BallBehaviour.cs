using UnityEngine;
using System.Collections;

public class BallBehaviour : MonoBehaviour
{
	public bool passed = false;
	public bool kicked = false;
	public Transform Target;
	public float speed = 50;
	float distance = -1;
	Rigidbody rgbd;
	// Use this for initialization
	void Start()
	{
		rgbd = GetComponent<Rigidbody>();
		distance = -1;
	}

	// Update is called once per frame
	void Update()
	{
		if (passed && Target != null && Vector3.Distance(transform.position,Target.position)> 0.1f)
		{
			rgbd.useGravity = false;
			rgbd.isKinematic = true;
			if (distance < 0) distance = (Target.position - transform.position).magnitude / speed;
            Vector3 dir = (Target.position - transform.position).normalized;
			//dir = new Vector3(dir.x, 0, dir.z);

			transform.position += dir * Time.deltaTime * distance;
		}
		else
		{
			passed = false;
			distance = -1;
			Target = null;
			rgbd.useGravity = true;
			rgbd.isKinematic = false;
		}
	}
}

