using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlyUp : MonoBehaviour
{
    public float forceMultiplier = 100.0f; // Adjust this value to control the force applied.

    private Rigidbody rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    private void Update()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");

        Vector3 forceDirection = new Vector3(horizontalInput, verticalInput, 0);

        // Apply force to the Rigidbody to make the cube fly.
        rb.AddForce(forceDirection * forceMultiplier);
    }
}
