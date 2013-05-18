using UnityEngine;
using System.Collections;

public class SpawnLevel : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {
        Vector3 wrapmax = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, Camera.main.transform.position.z));
        Vector3 wrapmin = Camera.main.ScreenToWorldPoint(new Vector3(0, 0, Camera.main.transform.position.z));
        for (int i = 0; i < 10; i++)
        {
            float x;
            float y;
            if (i % 4 == 0)
            {
                x = wrapmax.x;
                y = Random.Range(wrapmax.y, wrapmin.y);
            }
            else if (i % 4 == 1)
            {
                x = Random.Range(wrapmax.x, wrapmin.x);
                y = wrapmin.y;
            }
            else if (i % 4 == 2)
            {
                x = wrapmin.x;
                y = Random.Range(wrapmax.y, wrapmin.y);
            }
            else
            {
                x = Random.Range(wrapmax.x, wrapmin.x);
                y = wrapmin.y;
            }

            GameObject ob = GameObject.CreatePrimitive(PrimitiveType.Sphere);
            Vector3 pos = new Vector3(x, y, 0);
            Rigidbody gameObjectsRigidBody = ob.AddComponent<Rigidbody>();
            gameObjectsRigidBody.mass = 1;
            gameObjectsRigidBody.useGravity = false;
            ob.rigidbody.position = pos;
            ob.AddComponent("RandomMovement");
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}
