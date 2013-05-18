using UnityEngine;
using System.Collections;

public class SpawnLevel : MonoBehaviour {

	// Use this for initialization
	void Start () {
		for(int i = 0 ; i <10 ; i++)
		{
			float x = Random.Range (-100f, 100f);
			float y = Random.Range (-100f, 100f);
			//	Object ob = Instantiate (GameObject.FindGameObjectWithTag ("Finish"));
			
		}
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
