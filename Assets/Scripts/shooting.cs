using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class shooting : MonoBehaviour 
{
	public GameObject shot;
	public Transform shotSpawn;
	public float fireRate;
	public float speed;
	private float nextFire;





	void Update ()
	{
		{
			if (Input.GetKeyDown("space") && Time.time > nextFire)
			{
				nextFire = Time.time + fireRate;
				Instantiate (shot, shotSpawn.position, shotSpawn.rotation);
			}

		}
	}
}