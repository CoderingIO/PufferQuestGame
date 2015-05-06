using UnityEngine;
using System.Collections;

public class quillDeath : MonoBehaviour {


	public LayerMask layerMask;

	void OnTriggerEnter2D(Collider2D other)
		
	{
			DestroyObject(gameObject);
			

	} 
}


