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
            Vector3 pos = new Vector3(x, 0, y);
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
