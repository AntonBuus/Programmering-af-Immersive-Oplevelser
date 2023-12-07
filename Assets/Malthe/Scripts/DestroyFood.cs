using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyFood : MonoBehaviour
{

    public GoodSoup Soup;

    public void destroySelf()
    {
        if (Soup.IsTomatoin == true && Soup.isCarrotin == true && Soup.isSteakin == true)
                Invoke("destroyobject", 3f);
        
    }


    public void FixedUpdate()
    {
        if (Soup.IsTomatoin == true && Soup.isCarrotin == true && Soup.isSteakin == true)
            Invoke("destroyobject", 3.0f);
    }

    void destroyobject()
    {
        Destroy(gameObject);
    }
    

}
