using UnityEngine;
using System.Collections;


public class jellyDeath : MonoBehaviour 
{ 
	public Animator death;
	private bool isDead;
	public AudioClip jDied;


	
	void Update () {
		
	}
	
	void OnTriggerEnter2D(Collider2D other)
		
		
	{

		if(other.gameObject.tag == "quill" && isDead == false)
		   
		{
			//death.SetTrigger("Dying");

			isDead = true;
			DestroyObject(gameObject, 1);
			currentScore.Score += 500;
			GetComponent<Collider2D>().enabled = false;
			GetComponent<SpriteRenderer>().enabled = false;
			AudioSource.PlayClipAtPoint(jDied, new Vector3(0, 0, 0));

			
		}
	} 
}
