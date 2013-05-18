using UnityEngine;
using System.Collections;

public class Score : MonoBehaviour
{
	float _score;
	// Use this for initialization
	void Start ()
	{
		_score = 0;
		guiText.fontSize = 30;
		guiText.text = "Score: " + _score.ToString ("F2");
		transform.position = new Vector3(0, 1, 0);
	}
	
	// Update is called once per frame
	void Update ()
	{
		_score+=Time.deltaTime;
		guiText.text = "Score: " + _score.ToString ("F2");
		//setPosition ();
	}
	
	public void saveScore()
	{
		System.IO.File.WriteAllText ("../Score/somewhere.txt", _score.ToString ("F2"));	
	}
	public string readScore()
	{
		string score = System.IO.File.ReadAllText ("../Score/somewhere.txt");
		return score;
	}
}

