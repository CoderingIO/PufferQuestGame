using UnityEngine;
using System.Collections;
using UnityEngine.UI;
		
public class wBshooting : MonoBehaviour 
{
	public GameObject shot;
	public float fireRate;
	public float speed;
	private float nextFire;
	public float bulletSpeed = 500;
	public AudioClip fired;
			
			
	void Start ()
	{

	}
			
			
			
	void Update ()
	{
		GameObject instance;
		{
			if (Input.GetKeyDown("space") && Time.time > nextFire)
			{
				nextFire = Time.time + fireRate;
				instance = Instantiate(shot, transform.position, transform.rotation) as GameObject;
				instance.transform.rotation = Quaternion.identity;
				AudioSource.PlayClipAtPoint(fired, new Vector3(0, 0, 0));



				if (playerController.right == false)
				{
					instance.GetComponent<Rigidbody2D>().AddForce(transform.right * bulletSpeed);
					instance.transform.localScale = new Vector3(.5f, .5f, 1f);


				}

				else
				{
					instance.GetComponent<Rigidbody2D>().AddForce(transform.right * -bulletSpeed);
					instance.transform.localScale = new Vector3(-.5f, .5f, 1f);


				}

			}

		}			
	}

}


