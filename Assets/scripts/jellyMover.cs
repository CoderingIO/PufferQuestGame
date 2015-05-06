using UnityEngine;
using System.Collections;

public class jellyMover : MonoBehaviour
{
	public bool movingRight;
	public float targetSpeed = 1f;
	public float raycastLength = 1f;
	public new Rigidbody2D rigidbody2D;
	public float forceMultiplier;


	public LayerMask layerMask;






	void FixedUpdate()
	{
		if (movingRight && rigidbody2D.velocity.x < targetSpeed)
			rigidbody2D.AddForce(Vector2.right * forceMultiplier);

		else if (!movingRight && -rigidbody2D.velocity.x < targetSpeed)
			rigidbody2D.AddForce(-Vector2.right * forceMultiplier);


		RaycastHit2D hit = Physics2D.Raycast(rigidbody2D.position, Vector2.right, raycastLength, layerMask);
		if (hit.collider != null)
		{

			movingRight = false;
			transform.localScale = new Vector3(1f, 1f, 1f);
		}

		hit = Physics2D.Raycast(rigidbody2D.position, -Vector2.right, raycastLength, layerMask);
		if (hit.collider != null)
		{

			movingRight = true;
			transform.localScale = new Vector3(1f, -1f, 1f);
		}
	}

	void OnDrawGizmos()
	{
		Gizmos.DrawLine(rigidbody2D.position, rigidbody2D.position + Vector2.right * raycastLength);
	}
}
