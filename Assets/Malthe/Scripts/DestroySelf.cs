using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroySelf : MonoBehaviour
{
    

    public void Destroysself()
    {

        Invoke("Destroy", 2.5f);

    }

    
    void Destroy()
    {

    }


}
