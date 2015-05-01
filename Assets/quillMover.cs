
using UnityEngine;
using System.Collections;

public class move : MonoBehaviour {
	
	public float speed;
	
	
	void Start ()
	{
	
		
	}
	
	// Update is called once per frame
	void Update ()
	{
		GetComponent<Rigidbody>().AddForce(transform.right * speed);
	}
}