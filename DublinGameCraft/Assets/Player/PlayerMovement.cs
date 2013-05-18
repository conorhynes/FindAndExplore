using UnityEngine;
using System.Collections;

public class PlayerMovement : MonoBehaviour {

public float MoveSpeed = 10;
public float RotateSpeed = 40;
 
	void Start()
	{
	}
	// Update is called once per frame
	 
	void Update () 
	{
	    // Amount to Move
	 	
		float Horizonal = Input.GetAxis("Horizontal") * Time.deltaTime * MoveSpeed;
	 	float Vertical = Input.GetAxis("Vertical") * Time.deltaTime * MoveSpeed;

	    // Move the player
	    transform.Translate(Horizonal,0,Vertical);
	 
	}
}
