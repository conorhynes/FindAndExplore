// C#
using UnityEngine;
using System.Collections;

public class MenuScreen : MonoBehaviour {

	void OnGUI () {
		if (GUI.Button(new Rect(Screen.width / 2 - 100, Screen.height / 2 - 100, 200, 50), "STAAAAAAARRRRt")) {
			Application.LoadLevel ("GameProgress"); 
		}
	}
}
