using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pipes : MonoBehaviour
{
    // Start is called before the first frame update
    public float speed = 5f;
    private float leftEdge;

    private void Update()
    {
        transform.position += Vector3.left * speed * Time.deltaTime;

        if (transform.position.x <  leftEdge)
        {
            Destroy(gameObject);
        }
    }

    private void Start()
    {
        leftEdge = Camera.main.ScreenToWorldPoint(Vector3.zero).x - 1f;
    }
}
