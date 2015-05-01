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
	public float bulletSpeed = 500;
			
			
	void Start ()
	{

	}
			
			
			
	void Update ()
	{
		GameObject instance;
		{
		if (Input.GetKeyDown(KeyCode.Space) && Time.time > nextFire)
			{
				nextFire = Time.time + fireRate;
				instance = Instantiate(shot, transform.position, transform.rotation) as GameObject;
				instance.transform.rotation = Quaternion.AngleAxis(0, Vector3.forward);
				instance.GetComponent<Rigidbody2D>().AddForce(transform.right * bulletSpeed);
			}

		}			
	}
	//void OnTriggerEnter2D (Collider2D other)
	//{
//if (other.gameObject.tag == "fightingFish" || other.gameObject.tag == "jellyfish")
//		{

//			DestroyObject (other.gameObject);
//		}
//	}
}


