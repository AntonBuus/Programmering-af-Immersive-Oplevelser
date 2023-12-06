using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoodSoup : MonoBehaviour
{

    //public GameObject prefab1;
    public GameObject prefab2;

    public bool HaveSpawned = false;
    public bool IsTomatoin = false;
    public bool isCarrotin = false;
    public bool isSteakin = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void TomatoTrue()
    {
        IsTomatoin=true;
    }

    public void CarrotTrue()
    {
        isCarrotin=true;
    }

    public void SteakTrue()
    {
        isSteakin=true;
    }

    /*public void SwitchtoSoup()
    {
        if (HaveSpawned == false && IsTomatoin == true && isCarrotin == true && isSteakin == true)
        {
            HaveSpawned = true;
            Invoke("SwitchObjects", 3f);
        }



    } 
    */
    
    void FixedUpdate()
    {
        if (HaveSpawned == false && IsTomatoin == true && isCarrotin == true && isSteakin == true)
        {
            HaveSpawned = true;
            Invoke("SwitchObjects", 3f);
        }
    }
    
    // Update is called once per frame
    void SwitchObjects()
    {
        // Destroy the first prefab
        //Destroy(prefab1);

        // Instantiate the second prefab
        Debug.Log("Im trying to spawn");
        Instantiate(prefab2, transform.position, transform.rotation);
        HaveSpawned = true;
    }
}
