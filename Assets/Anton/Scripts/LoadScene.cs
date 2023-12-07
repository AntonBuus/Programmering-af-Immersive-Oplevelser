using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class LoadScene : MonoBehaviour
{
    // Start is called before the first frame update
    public void LoadIntroScene()
    {
        Wait(5);
        SceneManager.LoadScene("IntroScene");
    }

    // Update is called once per frame
    public void LoadKitchen()
    {
        Wait(5);
       SceneManager.LoadScene("Kitchen1"); 
    }

    private IEnumerator Wait(float delayInSeconds)
    {
        yield return new WaitForSeconds(delayInSeconds);
        
    }
}
