using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightSwitch : MonoBehaviour
{   
    public GameObject targetObject; // Reference to the GameObject you want to toggle

     public void LightOnOff()
    {
        if (targetObject != null)
        {
            targetObject.SetActive(!targetObject.activeSelf);
        }    
    }
}
