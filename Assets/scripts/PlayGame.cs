<<<<<<< HEAD
﻿//using UnityEngine;
//using System.Collections;
=======
﻿using UnityEngine;
using System.Collections;
using UnityEngine.UI;
>>>>>>> 3590ebd6ea15ce2b013c803c621ee42975227f9f

//public class PlayGame : MonoBehaviour {

	public InputField playerName;

	
	// Update is called once per frame
<<<<<<< HEAD
	//public void OnClickEnter () {
	//	Application.LoadLevel ("Stage Select");
	//}
//}


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
=======
	public void OnClickEnter () {
		PlayerPrefs.SetString("playerName", playerName.text);
		Application.LoadLevel ("Stage Select");
>>>>>>> 3590ebd6ea15ce2b013c803c621ee42975227f9f
	}
	
	
}
