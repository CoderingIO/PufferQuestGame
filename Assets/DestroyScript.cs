using UnityEngine;
using System.Collections;


public class DestroyScript : MonoBehaviour { void Start ()
		
		{
			
		}
		
		void Update () {
			
		}
		
		void OnTriggerEnter2D(Collider2D other)

			
		{
		Debug.Log ("I was hit");
			if(other.gameObject.tag == "Enemy")

				
			{
				
				DestroyObject(other.gameObject);
				
			}
		} }



// public bool characterInQuicksand;
// void OnTriggerEnter2D(Collider2D other) {
//	characterInQuicksand = true;