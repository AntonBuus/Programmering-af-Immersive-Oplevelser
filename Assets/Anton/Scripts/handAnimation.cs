using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class handAnimation : MonoBehaviour
{
    public InputActionProperty pinchAnimation;
    public InputActionProperty grabAnimation;

    public Animator handAnimationThing;
   
    void Update()
    {
        float pinchValue = pinchAnimation.action.ReadValue<float>();
        // print("Pinch Value: " + pinchValue);

        handAnimationThing.SetFloat("Pinch", pinchValue);

        float grabValue = grabAnimation.action.ReadValue<float>();
        // print("Grab Value: " + grabValue);

        handAnimationThing.SetFloat("Grab", grabValue);
    }
}
