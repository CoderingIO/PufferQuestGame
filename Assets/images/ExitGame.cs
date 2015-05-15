using UnityEngine;
using System.Collections;

public class ExitGame : MonoBehaviour {

	public void OnClickEnter () {
		Application.Quit();
		Debug.Log ("I quit");
	}
}
