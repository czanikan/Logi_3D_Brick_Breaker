using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallController : MonoBehaviour
{
    public float speed;

    private Rigidbody rb;

    private void Start()
    {
        speed = 5;
        rb = GetComponent<Rigidbody>();
        rb.AddForce(0, 0, -speed, ForceMode.Impulse);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player")
        {

        }
    }
}
