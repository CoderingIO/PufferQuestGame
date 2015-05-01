using UnityEngine;
using System.Collections;

public class quillDeath : MonoBehaviour {


	
	void OnTriggerEnter2D(Collider2D other)
		
		
	{
		Debug.Log ("I was hit");
		if(gameObject.tag == "quill")
			
			
		{
			
			DestroyObject(gameObject);
			
		}
	} 
}


