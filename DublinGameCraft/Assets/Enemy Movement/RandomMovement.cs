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
            pos.x = wrapmax.x;
            //vel.x = vel.x * -1;
        }
        else if (transform.position.x < wrapmax.x)
        {
            pos.x = wrapmin.x;
            //vel.x = vel.x * -1;
        }
        if (transform.position.y > wrapmin.y)
        {
            pos.y = wrapmax.y;
            //vel.y = vel.y * -1;
        }
        else if (transform.position.y < wrapmax.y)
        {
            pos.y = wrapmin.y;
            //vel.y = vel.y * -1;
        }
        transform.position = pos;
    }

    public int Colour
    {
        get { return _colour; }
        set { _colour = value; }
    }
}
