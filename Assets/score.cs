using UnityEngine;
using System.Collections;

public class score : MonoBehaviour {
	public GUIText scoreText;
	private int Score;

	public void AddScore (int newScoreValue)
	{
		Score += newScoreValue;
		UpdateScore ();
	}
	
	void UpdateScore()
	{
		scoreText.text = "Score: " + Score;
		
	}
}
