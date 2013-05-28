using UnityEngine;
using System.Collections;

public class PlayerMovement : MonoBehaviour {

public float MoveSpeed = 10;
 
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
	    transform.Translate(Horizonal,Vertical,0);
	 
	}
	
	void OnBecameInvisible()
    {
        Vector3 pos = transform.position;
        Vector3 wrapmin = Camera.main.ScreenToWorldPoint(new Vector3(0, 0, Camera.main.transform.position.z));
        Vector3 wrap = new Vector3(wrapmin.y - 0, wrapmin.x - 0);
        Vector3 wrapmax = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, Camera.main.transform.position.z));
        Vector3 wrapMax = new Vector3(wrapmax.y + 0, wrapmax.x + 0);

        if (transform.position.x > wrapmin.x)
        {
            pos.x = wrapmax.x - 1;
            //vel.x = vel.x * -1;
        }
        else if (transform.position.x < wrapmax.x)
        {
            pos.x = wrapmin.x + 1;
            //vel.x = vel.x * -1;
        }
        if (transform.position.y > wrapmin.y)
        {
            pos.y = wrapmax.y - 1;
            //vel.y = vel.y * -1;
        }
        else if (transform.position.y < wrapmax.y)
        {
            pos.y = wrapmin.y + 1;
            //vel.y = vel.y * -1;
        }
        transform.position = pos;
    }
}
