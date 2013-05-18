using UnityEngine;
using System.Collections;

public class MagneticPull : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	GameObject target;
 
    // Update is called once per frame
    void Update () {
		target = GameObject.Find("Cube");
		
		
        if (target.layer != gameObject.layer) {   
            this.transform.LookAt( target.transform );
            this.transform.position = Vector3.Lerp( transform.position, target.transform.position, Time.deltaTime);
        }
    }

}
