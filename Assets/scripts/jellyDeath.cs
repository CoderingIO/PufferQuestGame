using UnityEngine;
using System.Collections;


public class jellyDeath : MonoBehaviour 
{ 
	public Animator death;
	
	void Update () {
		
	}
	
	void OnTriggerEnter2D(Collider2D other)
		
		
	{

		if(other.gameObject.tag == "quill")
		{
			death.SetTrigger("Dying");
			DestroyObject(gameObject, 5);
			currentScore.Score += 500;
		}
	} 
}
