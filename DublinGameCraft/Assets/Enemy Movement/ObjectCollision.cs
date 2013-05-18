using UnityEngine;
using System.Collections;

public class ObjectCollision : MonoBehaviour {

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
			
			GameObject object1 = collision.collider.gameObject;
			RandomMovement object1Component;
        	object1Component = collision.collider.gameObject.GetComponent<RandomMovement>();
			
			GameObject object2 = contact.thisCollider.gameObject; 
			RandomMovement object2Component;
			object2Component = contact.thisCollider.gameObject.GetComponent<RandomMovement>();
			
			bool _willCollide = new bool();

			if(object1.layer == object2.layer)
			{
				_willCollide = true;
			}
			else if(object1.layer != object2.layer)
			{
				
				_willCollide = false;
			}
			
			if(_willCollide)
			{
				print ("falseCollide");
				Physics.IgnoreLayerCollision(contact.thisCollider.gameObject.layer,object1.layer);
			}
			else
			{
				print ("trueCollide");
				Physics.IgnoreLayerCollision(contact.thisCollider.gameObject.layer,object1.layer,false);
			}
			

		}
	}
	
}
