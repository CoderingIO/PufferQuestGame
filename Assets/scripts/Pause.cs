using UnityEngine;
using System.Collections;

public class Pause : MonoBehaviour {
	
	public GameObject PauseMenu;
	// Update is called once per frame
	void Update () 
	{
		if(Input.GetButtonDown("Escape"))
		{
			Debug.Log ("I am pressed");
			PauseMenu.SetActive(true);
			Time.timeScale = 0;

		}
		if(Time.timeScale == 0)
		{
			if(Input.GetButtonDown("Escape"))
			{
				Time.timeScale = 1;
				PauseMenu.SetActive(false);
			}		
		}
	}
}
