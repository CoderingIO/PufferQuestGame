using UnityEngine;
using System.Collections;

public class quillDeath : MonoBehaviour {




	void OnTriggerEnter2D(Collider2D other)
		
	{
			DestroyObject(gameObject);
			

	} 
}


