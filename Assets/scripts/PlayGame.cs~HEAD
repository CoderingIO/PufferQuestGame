using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class PlayGame : MonoBehaviour {

	public InputField playerName;
	
	public void startGame ()
	{
		HighScoreManager.ClearLeaderBoard ();
		PlayerPrefs.SetString ("playerName", playerName.text);
		Application.LoadLevel("WaynesAIzone");
		// Stage Select
		Debug.Log ("level is noticed");
	}
	

}
