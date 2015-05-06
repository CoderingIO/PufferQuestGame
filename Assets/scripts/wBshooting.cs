using UnityEngine;
using System.Collections;
using UnityEngine.UI;
		
public class wBshooting : MonoBehaviour 
{
	public GameObject shot;
	public Transform shotSpawn;
	public float fireRate;
	public float speed;
	private float nextFire;
	public float bulletSpeed = 500;
			
			
	void Start ()
	{

	}
			
			
			
	void Update ()
	{
		GameObject instance;
		{
			if (Input.GetButtonDown("Fire1") && Time.time > nextFire)
			{
				nextFire = Time.time + fireRate;
				instance = Instantiate(shot, transform.position, transform.rotation) as GameObject;
				instance.transform.rotation = Quaternion.AngleAxis(0, Vector3.forward);
				if (playerController.right == false)
				instance.GetComponent<Rigidbody2D>().AddForce(transform.right * bulletSpeed);
				else
					instance.GetComponent<Rigidbody2D>().AddForce(transform.right * -bulletSpeed);

			}

		}			
	}

}


