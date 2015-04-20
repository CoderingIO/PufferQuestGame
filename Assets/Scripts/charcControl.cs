using UnityEngine;
using System.Collections;
using UnityEngine.UI;	
using UnityEngine.Serialization;


[System.Serializable]
public class Boundary
{
	public float xMin, xMax, zMin, zMax;
}

public class charcControl : MonoBehaviour
{
	public Animator animator;
	public float moveSpeed;
	public Boundary boundary;
	public bool movingRight = true;
	public new Rigidbody2D rigidbody2D;
	public float forceMultiplier = 1f;
	public float targetSpeed = 1f;
	public float raycastLength = 1f
	public LayerMask layerMask;
	
			
	void FixedUpdate()
			{
				if (movingRight && rigidbody2D.velocity.x < targetSpeed)
					rigidbody2D.AddForce(Vector2.right * forceMultiplier);
				else if (!movingRight && -rigidbody2D.velocity.x < targetSpeed)
					rigidbody2D.AddForce(-Vector2.right * forceMultiplier);
				
			}
				hit = Physics2D.Raycast(rigidbody2D.position, -Vector2.right, raycastLength);
				if (hit.collider != null)
				{
					Debug.Log("I hit a " + hit.collider.name);
					movingRight = true;
					transform.localScale = new Vector3(1f, 1f, 1f);
				}
				
				GetComponent<Animator>().SetFloat("Speed", rigidbody2D.velocity.magnitude);
			}
			
			void OnDrawGizmos()
			{
				Gizmos.DrawLine(rigidbody2D.position, rigidbody2D.position + Vector2.right * raycastLength);
			}
		

		

}

