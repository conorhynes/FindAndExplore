using UnityEngine;
using System.Collections;

public class RandomMovement : MonoBehaviour {
	Vector3 _direction;
	bool forceAdded = false;
	// Use this for initialization
	void Start () {
		float x = Random.Range (-1f, 1f);
		float y = Random.Range (-1f, 1f);
		_direction = new Vector3(x, 0, y);
		if(!forceAdded)
		{
			_direction = _direction.normalized;
			forceAdded = true;
			rigidbody.AddForce(_direction * 10);
		}
	}
	
	// Update is called once per frame
	void Update () {
	}
}
