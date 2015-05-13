using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class PlayGame : MonoBehaviour {

	public InputField playerName;
	
	public void startGame ()
	{

		PlayerPrefs.SetString ("playerName", playerName.text);
		Application.LoadLevel("WaynesAIzone");
		Debug.Log ("level is noticed");
	}
	

}
