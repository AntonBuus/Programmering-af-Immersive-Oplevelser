using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttatchGlasses : MonoBehaviour
{
    public GameObject targetObject; // The object to attach to
    public string attachTag = "Attachable"; // Tag of objects that can be attached

    private void OnTriggerEnter(Collider collision)
    {
        
        if (collision.gameObject.CompareTag(attachTag))
        {
            AttachObjectToTarget();
            Debug.Log("Collision detected");
        }
    }
    

    private void AttachObjectToTarget()
    {
        Rigidbody attachedRb = GetComponent<Rigidbody>();
        Rigidbody targetRb = targetObject.GetComponent<Rigidbody>();

        // Check if both objects have Rigidbody components
        if (attachedRb != null && targetRb != null)
        {
            // Make the attached object a child of the target object
            transform.parent = targetObject.transform;

            // Disable the Rigidbody of the attached object to prevent physics interactions
            attachedRb.isKinematic = true;

            // Optionally, you can add more behavior here based on your requirements
        }
    }
}
