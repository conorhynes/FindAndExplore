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
        _direction = new Vector3(x, 0, y);
        _direction = _direction.normalized;
        rigidbody.AddForce(_direction * 10);
    }

    // Update is called once per frame
    void Update()
    {
    }

    void onBecomeInvisible()
    {
        Vector3 pos = rigidbody.position;
        float camXMax = Camera.mainCamera.pixelWidth;
        float camYMax = Camera.mainCamera.pixelHeight;
        float camXMin = Camera.mainCamera.pixelWidth - Camera.mainCamera.GetScreenWidth();
        float camYMin = Camera.mainCamera.pixelHeight - Camera.mainCamera.GetScreenHeight();
    }

    public int Colour
    {
        get { return _colour; }
        set { _colour = value; }
    }
}
