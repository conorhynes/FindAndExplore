using UnityEngine;
using System.Collections;

public class RandomMovement : MonoBehaviour
{
    Vector3 _direction;
    int _colour;

    // Use this for initialization
    void Start()
    {
        float x = Random.Range(-1f, 1f);
        float y = Random.Range(-1f, 1f);
        _direction = new Vector3(x, y, 0);
        _direction = _direction.normalized;
        rigidbody.AddForce(_direction * 50);
    }

    // Update is called once per frame
    void Update()
    {
        int rand;
        Vector3 pos = transform.position;
        pos.z = 0;
        transform.position = pos;
        if (rigidbody.velocity.x == 0)
        {
            rand = Random.Range(1, 3);
            if (rand % 2 == 0)
            {
                rigidbody.AddForce(new Vector3(0.1f, 0, 0));
            }
            else
            {
                rigidbody.AddForce(new Vector3(-0.1f, 0, 0));
            }
        }
        if (rigidbody.velocity.y == 0)
        {
            rand = Random.Range(1, 3);
            if (rand % 2 == 0)
            {
                rigidbody.AddForce(new Vector3(0, 0.1f, 0));
            }
            else
            {
                rigidbody.AddForce(new Vector3(0, -0.1f, 0));
            }
        }
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

    public int Colour
    {
        get { return _colour; }
        set { _colour = value; }
    }
	
	public void warp()
	{
		Vector3 pos = transform.position;
        Vector3 wrapmin = Camera.main.ScreenToWorldPoint(new Vector3(0, 0, Camera.main.transform.position.z));
        Vector3 wrap = new Vector3(wrapmin.y - 0, wrapmin.x - 0);
        Vector3 wrapmax = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, Camera.main.transform.position.z));
        Vector3 wrapMax = new Vector3(wrapmax.y + 0, wrapmax.x + 0);
		
		
		if(rigidbody.velocity.y > 0)
		{
            pos.y = wrapmax.y - 1;
		}
		else if(rigidbody.velocity.y < 0)
		{
            pos.x = wrapmin.y + 1;
		}
		if(rigidbody.velocity.x > 0)
		{
            pos.x = wrapmax.x - 1;
		}
		else if(rigidbody.velocity.y < 0)
		{
            pos.x = wrapmin.x + 1;
		}
	}
}
