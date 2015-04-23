using UnityEngine;
using System.Collections;
using UnityEngine.UI;	
using UnityEngine.Serialization;



public class charcControl : MonoBehaviour
{
	public float moveSpeed;
	public bool movingRight = true;
	public new Rigidbody2D rigidbody2D;
	public float forceMultiplier = 1f;
	public float targetSpeed = 1f;

			
	void Update ()

	{ 
	float moveHorizontal = Input.GetAxis ("Horizontal");
	float moveVertical = Input.GetAxis ("Vertical");

	rigidbody2D.AddForce(Vector2.right * forceMultiplier);
	}
		

		

}

