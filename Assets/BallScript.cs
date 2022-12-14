using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallScript : MonoBehaviour
{
    private Rigidbody rb;
    public Vector3 DefaultPosition;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.y < 0)
        {
            rb.velocity = Vector3.zero;
            transform.position = DefaultPosition;
        }
    }
}
