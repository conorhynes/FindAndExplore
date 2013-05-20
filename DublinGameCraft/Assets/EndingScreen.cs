// C#
using UnityEngine;
using System.Collections;

public class EndingScreen : MonoBehaviour {

	void OnGUI () {
		if (GUI.Button(new Rect(Screen.width / 2 - 100, Screen.height / 2 - 100, 200, 50), "EEENNNNDDDD")) {
			Application.LoadLevel ("MainMenu"); 
		}
	}
}
