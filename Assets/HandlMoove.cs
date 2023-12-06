using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HandlMoove : MonoBehaviour
{
    //private bool hasMoved = false;

    //void OnTriggerEnter(Collision collision)
    //{
    // Check if the collision involves movement
    //  if (collision.relativeVelocity.magnitude > 0.1f && !hasMoved)
    // {
    // Play the sound
    //   FindObjectOfType<AudioManager>().PlayVoice("FridgeOpen");
    //   Debug.LogWarning("Audio is playing");
    //   // Prevent multiple plays during continuous collision
    //}
    //}

    private Vector3 lastPosition;
    private bool hasMoved = false;
    public float distance = 0.1f;

    void Start()
    {
        // Initialize the last position
        lastPosition = transform.position;
    }

    void LateUpdate()
    {
        _hasMoved();
    }

    void _hasMoved()
    {
        // Check if the position has changed
        if (transform.position.magnitude > distance && !hasMoved)
        {
            // Play the sound
            FindObjectOfType<AudioManager>().Play("FridgeOpen");
            Debug.LogWarning("Audio is playing");
            lastPosition = transform.position; // Update the last position
            hasMoved = true;
        }
    }
}
