using UnityEngine;
using System.Collections;

public class CollisionControl : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnCollisionEnter(Collision collision)
	{
		foreach(ContactPoint contact in collision.contacts)
		{
			RandomMovement other;
        	other = collision.collider.gameObject.GetComponent<RandomMovement>();
			GameObject otherObject = collision.collider.gameObject;
			
			PlayerColour playerObjectComponent;
			playerObjectComponent = contact.thisCollider.gameObject.GetComponent<PlayerColour>();
			GameObject playerObject;
			playerObject = contact.thisCollider.gameObject;
			
			bool _willCollide = new bool();

			if(otherObject.layer == playerObject.layer)
			{
				_willCollide = true;
			}
			else if(otherObject.layer != playerObject.layer)
			{
				
				_willCollide = false;
			}
			
			if(_willCollide)
			{
				print ("falseCollide");
				Physics.IgnoreLayerCollision(contact.thisCollider.gameObject.layer,collision.collider.gameObject.layer);
			}
			else
			{
				print ("trueCollide");
				Physics.IgnoreLayerCollision(contact.thisCollider.gameObject.layer,collision.collider.gameObject.layer,false);
				GameObject ob = GameObject.FindGameObjectWithTag ("Player");
				Score score = ob.GetComponent<Score>();
				score.saveScore ();
			}
			

		} 

	}
}
