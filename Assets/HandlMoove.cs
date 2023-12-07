using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HandlMoove : MonoBehaviour
{
    private Vector3 initialPosition;
    private Vector3 lastPosition;
    private bool hasMoved = false;
    public float distance = 0.1f;
    public string clipName;
    public float _delay = 3.0f;
    public float retracctSpeed = 1.0f;

    void Start()
    {
        // Initialize the initial and last positions
        initialPosition = transform.position;
        lastPosition = initialPosition;
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
            lastPosition = transform.position; // Update the last position
            hasMoved = true;

            StartCoroutine(ResetBool(_delay));
        }
    }

    IEnumerator ResetBool(float delay)
    {
        yield return new WaitForSeconds(delay);
        hasMoved = false;

        // Smoothly move the object back to its initial position
        StartCoroutine(MoveBack());
    }

    IEnumerator MoveBack()
    {
        float passedTime = 0f;

        while (passedTime < 1f)
        {
            transform.position = Vector3.Lerp(transform.position, initialPosition, Time.deltaTime * retracctSpeed);
            passedTime += Time.deltaTime;
            yield return null;
        }

        // Ensure the object is exactly at the initial position
        transform.position = initialPosition;
    }
}
