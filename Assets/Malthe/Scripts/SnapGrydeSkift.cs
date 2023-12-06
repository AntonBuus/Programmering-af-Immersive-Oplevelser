using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SnapGrydeSkift : MonoBehaviour
{
    public GameObject prefab1;
    public GameObject prefab2;

    public bool Waterisrunning = false;
    public bool IsPlaced = false;
    public bool HaveSpawned = false;

    void Start()
    {
        // Instantiate the first prefab
        
        // Invoke the SwitchObjects method after 3 seconds
       
    }

    public void SetWater()
    {
        Waterisrunning = true;
    }

    public void PlacingThing()
    {
        IsPlaced = true;


        
    }

    void FixedUpdate()
    {
        if (HaveSpawned == false && Waterisrunning == true && IsPlaced == true)
        {
            HaveSpawned = true;
            Invoke("SwitchObjects", 3f);
        }

    }


    void SwitchObjects()
    {
        // Destroy the first prefab
        Destroy(prefab1);

        // Instantiate the second prefab
        Instantiate(prefab2, transform.position, transform.rotation);
        
    }
}
