using UnityEngine;
using System.Collections;

public class Pause : MonoBehaviour {
	
	public GameObject PauseMenu;
	// Update is called once per frame
	void Update () 
	{
		if(Input.GetButtonDown("Cancel"))
		{
			Time.timeScale = 0;
			PauseMenu.SetActive(true);
		}
		if(Time.timeScale == 0 && Input.GetButtonDown("Cancel"))
		{
			Time.timeScale = 1;
			PauseMenu.SetActive(false);
		}
	}
}
