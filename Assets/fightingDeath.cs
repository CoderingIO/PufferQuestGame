using UnityEngine;
using System.Collections;

public class fightingDeath : MonoBehaviour {
	

		void OnTriggerEnter2D(Collider2D other)
			
			
		{
			Debug.Log ("I was hit");
			if(other.gameObject.tag == "quill")
				
				
			{
				
				DestroyObject(gameObject);
				score.Score += 1000;
				
			}
		} 
	}
	
	

