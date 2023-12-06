using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HandlMoove : MonoBehaviour
{
    private Vector3 lastPosition;
    private bool hasMoved = false;
    public float distance = 0.1f;
    public string clipName;
    public float _delay = 3.0f;

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
        // Check if the position has changed and if it has moved a certain distance
        if (Vector3.Distance(transform.position, lastPosition) > distance && !hasMoved)
        {
            // Play the sound
            FindObjectOfType<AudioManager>().Play(clipName);
            //Debug.LogWarning("Audio is playing");
            lastPosition = transform.position; // Update the last position
            hasMoved = true;

            StartCoroutine(ResetBool(_delay));
        }
    }


    IEnumerator ResetBool(float delay)
    {
        yield return new WaitForSeconds(delay);
        hasMoved = false;
    }
}
