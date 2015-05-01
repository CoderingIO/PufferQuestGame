using UnityEngine;
using System.Collections;

public class fightingMover : MonoBehaviour {
	public float speed;
	// Use this for initialization
	void Start () 
	{
		GetComponent<Rigidbody2D> ().velocity = transform.up * speed;
	}
}
