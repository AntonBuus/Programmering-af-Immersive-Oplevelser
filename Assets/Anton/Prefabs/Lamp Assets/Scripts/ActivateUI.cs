using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivateUI : MonoBehaviour
{
    public GameObject ObjectToDisable;

    public GameObject ObjectToEnable;


    public void ActivateGameObjects()
    {
        Debug.Log("Activated UI");
        StartCoroutine(Countdown(0f));
        ObjectToEnable.SetActive(true);
    }

    IEnumerator Countdown(float time)
    {
        yield return new WaitForSeconds(2f);
        ObjectToDisable.SetActive(false);
        
    }
}
