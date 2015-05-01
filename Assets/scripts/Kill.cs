using UnityEngine;
using System.Collections;

public class Kill : MonoBehaviour {
	public GameObject character;
	void OnTriggerExit(Collider other)
	{
		if(other.tag == "Char")
		{
			Destroy(character);
		}	
	}		
}
