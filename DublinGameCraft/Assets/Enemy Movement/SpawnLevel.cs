using UnityEngine;
using System.Collections;

public class SpawnLevel : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {
        for (int i = 0; i < 10; i++)
        {
            float x = Random.Range(-10f, 10f);
            float y = Random.Range(-10f, 10f);
            GameObject ob = GameObject.CreatePrimitive(PrimitiveType.Sphere);
            Vector3 pos = new Vector3(x, y, 0);
            Rigidbody gameObjectsRigidBody = ob.AddComponent<Rigidbody>();
            gameObjectsRigidBody.mass = 1;
            gameObjectsRigidBody.useGravity = false;
            ob.rigidbody.position = pos;
            float xMove = Random.Range(-1f, 1f);
            float yMove = Random.Range(-1f, 1f);
            Vector3 direction = new Vector3(xMove, yMove, 0);
            direction = direction.normalized * 50;
            ob.rigidbody.AddForce(direction);
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}
