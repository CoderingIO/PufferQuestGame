using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class PlayGame : MonoBehaviour {

	public InputField playerName;

	
	// Update is called once per frame
	public void OnClickEnter () {
		PlayerPrefs.SetString("playerName", playerName.text);
		Application.LoadLevel ("Stage Select");
	}
}
