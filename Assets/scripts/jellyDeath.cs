using UnityEngine;
using System.Collections;


public class jellyDeath : MonoBehaviour 
{ 

	
	void Update () {
		
	}
	
	void OnTriggerEnter2D(Collider2D other)
		
		
	{

		if(other.gameObject.tag == "quill")
		{
			DestroyObject(gameObject);
			currentScore.Score += 500;
		}
	} 
}
