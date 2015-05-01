using UnityEngine;
using System.Collections;

public class shooting : MonoBehaviour {
	
	public GameObject ThePrefab;
	private float fireRate = .15f;
	private float nextFire = 0;
	private float bulletSpeed = 500f;
	
	void Update () {
		GameObject instance;
		
		//shoot up
		if (Input.GetKeyDown(KeyCode.U) && Time.time > nextFire){
			nextFire = Time.time + fireRate;
			Debug.Log ("nf" + nextFire);
			instance = Instantiate(ThePrefab, transform.position, transform.rotation) as GameObject;
			instance.GetComponent<Rigidbody2D>().AddForce(transform.up * bulletSpeed);
		}
		
		//shoot left
		if (Input.GetKeyDown(KeyCode.L) && Time.time > nextFire){
			nextFire = Time.time + fireRate;
			instance = Instantiate(ThePrefab, transform.position, transform.rotation) as GameObject;
			instance.transform.rotation = Quaternion.AngleAxis(180, Vector3.forward);
			instance.GetComponent<Rigidbody2D>().AddForce(transform.right * -bulletSpeed);
		}
		
		//shoot down
		if (Input.GetKeyDown(KeyCode.D) && Time.time > nextFire){
			nextFire = Time.time + fireRate;
			instance = Instantiate(ThePrefab, transform.position, transform.rotation) as GameObject;
			instance.transform.rotation = Quaternion.AngleAxis(0, Vector3.right);
			instance.GetComponent<Rigidbody2D>().AddForce(transform.up * -bulletSpeed);
		}
		
		//shoot right
		if (Input.GetKeyDown(KeyCode.Space) && Time.time > nextFire){
			nextFire = Time.time + fireRate;
			instance = Instantiate(ThePrefab, transform.position, transform.rotation) as GameObject;
			instance.transform.rotation = Quaternion.AngleAxis(0, Vector3.forward);
			instance.GetComponent<Rigidbody2D>().AddForce(transform.right * bulletSpeed);
		}
	}
}
