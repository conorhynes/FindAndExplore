using UnityEngine;
using System.Collections;

public class SplashScore : MonoBehaviour {
	
	string _score;
	// Use this for initialization
	void Start () {
		_score = readScore ();
		guiText.fontSize = 30;
		guiText.text = "Score: " + _score;
		transform.position = new Vector3(0, 1, 0);
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	public string readScore()
	{
		string score = PlayerPrefs.GetString ("score");
		return score;
	}
}
