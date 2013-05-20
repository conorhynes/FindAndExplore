using UnityEngine;
using System.Collections;

public class SpawnLevel : MonoBehaviour
{
	int _spawnCount = 5;
	float _timer = 0;
	int _limit = 20;
	float disc;
    // Use this for initialization
    void Start()
    {
        generateNew ();
    }

    // Update is called once per frame
	void Update()
    {
		_timer += Time.deltaTime;
		if(_timer > _limit)
		{
			generateNew ();
			_spawnCount+=(_spawnCount/2) + 1;
			_timer = 0;
			if(_limit > 5)
			{
				_limit--;
			}
				disc = 0;
		}
		if(disc < 2)
		{
			Vector3 pos = Camera.main.transform.position;
			
			if(pos.z > -20)
			{
				pos = cameraPan (pos);	
				Camera.main.transform.position = pos;
			}
		}
    }
	
	Vector3 cameraPan(Vector3 pos)
	{
		pos.z-=0.1f;
		disc += 0.1f;
		return pos;
	}
	
	public void generateNew()
	{
		Vector3 wrapmax = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, Camera.main.transform.position.z));
        Vector3 wrapmin = Camera.main.ScreenToWorldPoint(new Vector3(0, 0, Camera.main.transform.position.z));
        for (int i = 0; i < _spawnCount; i++)
        {
            float x;
            float y;
            int rand = Random.Range(1, 5);
            if (rand % 4 == 0)
            {
                x = wrapmax.x;
                y = Random.Range(wrapmax.y, wrapmin.y);
            }
            else if (rand % 4 == 1)
            {
                x = Random.Range(wrapmax.x, wrapmin.x);
                y = wrapmin.y;
            }
            else if (rand % 4 == 2)
            {
                x = wrapmin.x;
                y = Random.Range(wrapmax.y, wrapmin.y);
            }
            else
            {
                x = Random.Range(wrapmax.x, wrapmin.x);
                y = wrapmin.y;
            }

            rand = Random.Range(1, 4);

            GameObject ob = GameObject.CreatePrimitive(PrimitiveType.Sphere);
            Vector3 pos = new Vector3(x, y, 0);
            Rigidbody gameObjectsRigidBody = ob.AddComponent<Rigidbody>();
            gameObjectsRigidBody.mass = 1;
            gameObjectsRigidBody.useGravity = false;
            ob.rigidbody.position = pos;
            ob.AddComponent("RandomMovement");
			ob.AddComponent("ObjectCollision");
			ob.AddComponent ("MagneticPull");

            RandomMovement move;
            move = ob.GetComponent<RandomMovement>();
            move.Colour = rand;
            if (rand == 1)
            {
                move.renderer.material.color = Color.blue;
				ob.layer = 9;
            }
            else if (rand == 2)
            {
                move.renderer.material.color = Color.green;
				ob.layer = 10;
            }
            else
            {
                move.renderer.material.color = Color.red;
				ob.layer = 8;
            }
        }
	}
}
