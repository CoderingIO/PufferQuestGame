using UnityEngine;
using System.Collections;

public class follow : MonoBehaviour 
{
	public float speed;
	Transform target;

	void Awake ()
	{
		target = GameObject.Find("ThirdPersonController").transform;

	}

	void Update ()
	{
		transform.position = Vector3.MoveTowards(transform.position, target.position, speed * Time.deltaTime);
		transform.LookAt(target);
	}

}
