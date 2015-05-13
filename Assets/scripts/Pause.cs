using UnityEngine;
using System.Collections;

public class Pause : MonoBehaviour {
	
	public GameObject PauseMenu;
	// Update is called once per frame
	void Update () 
	{
		if(Input.GetButtonDown("Escape")&& Time.timeScale == 1)
		{
			Debug.Log ("I am pressed");
			PauseMenu.SetActive(true);
			Time.timeScale = 0;

		}
		else if(Time.timeScale == 0 && Input.GetButtonDown("Escape"))
		{
				Time.timeScale = 1;
				PauseMenu.SetActive(false);
		}
	}
}
