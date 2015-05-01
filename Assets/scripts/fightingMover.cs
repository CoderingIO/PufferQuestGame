using UnityEngine;
using System.Collections;

public class fightingMover : MonoBehaviour 
{
	public float speed = 1f;
	private Transform target;
	private Transform myTransform;


	


	// Use this for initialization
	void Start () 
	{
		target = GameObject.Find("pufferFish").transform;

	}

	void Update ()
	{
		transform.position = Vector2.MoveTowards(transform.position, target.position, speed * Time.deltaTime);

	}
}
