using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HandlMoove : MonoBehaviour
{
    private bool hasMoved = false;

    void OnCollisionEnter(Collision collision)
    {
        // Check if the collision involves movement
        if (collision.relativeVelocity.magnitude > 0.1f && !hasMoved)
        {
            // Play the sound
            FindObjectOfType<AudioManager>().PlayVoice("FridgeOpen");
            hasMoved = true; // Prevent multiple plays during continuous collision
        }
    }
}
