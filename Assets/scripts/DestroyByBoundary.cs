using UnityEngine;
using System.Collections;

public class DestroyByBoundary : MonoBehaviour 
{

	public GameObject character;
	void Update()
	{
		DestroyImmediate(character, true);
	}		       
}