using UnityEngine;
using System.Collections;

public class PlayerColour : MonoBehaviour {

	int _colour;
	// Use this for initialization
	void Start () {
	 Colour = 1;
	}
	
	// Update is called once per frame
	void Update () {
	
		if(Input.GetKey(KeyCode.Alpha1))
		{
			gameObject.layer = 8;
            gameObject.renderer.material.color = Color.red;
		}
		else if(Input.GetKey(KeyCode.Alpha2))
		{
			gameObject.layer = 9;
            gameObject.renderer.material.color = Color.blue;
		}
		else if(Input.GetKey(KeyCode.Alpha3))
		{
			gameObject.layer = 10;
            gameObject.renderer.material.color = Color.green;
		}
		
		
	}
	
	public int Colour
    {
        get { return _colour; }
        set { _colour = value; }
    }

}
