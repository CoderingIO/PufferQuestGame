using UnityEngine;
using System.Collections;


[System.Serializable]
public class Boundary
{
	public float xMin, xMax, yMin, yMax;
}

public class playerController : MonoBehaviour
{
	public float speed = 1.5f;
	public static bool right;
	public Transform puffy;
	public Boundary boundary;

	
	void Update ()
	{
		if (Input.GetKey(KeyCode.LeftArrow))
		{
			transform.position += Vector3.left * speed * Time.deltaTime;
			transform.localScale = new Vector3(-1f, 1f, 1f);
			right = true;
		}
		if (Input.GetKey(KeyCode.RightArrow))
		{
			transform.position += Vector3.right * speed * Time.deltaTime;
			transform.localScale = new Vector3(1f, 1f, 1f);
			right = false;

		}
		if (Input.GetKey(KeyCode.UpArrow))
		{
			transform.position += Vector3.up * speed * Time.deltaTime;
		}
		if (Input.GetKey(KeyCode.DownArrow))
		{
			transform.position += Vector3.down * speed * Time.deltaTime;
		}
		GetComponent<Rigidbody2D>().position = new Vector2 
			(
				Mathf.Clamp (GetComponent<Rigidbody2D>().position.x, boundary.xMin, boundary.xMax), 
			 
				Mathf.Clamp (GetComponent<Rigidbody2D>().position.y, boundary.yMin, boundary.yMax)
				);
	}
}