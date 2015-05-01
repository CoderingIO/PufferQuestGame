using UnityEngine;
using System.Collections;


public class jellyDeath : MonoBehaviour 
{ 

	
	void Update () {
		
	}
	
	void OnTriggerEnter2D(Collider2D other)
		
		
	{
		Debug.Log ("I was hit");
		if(other.gameObject.tag == "quill")
			
			
		{
			
			DestroyObject(gameObject);
			score.Score += 500;
			
		}
	} 
}
