using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class SkydSkyd : MonoBehaviour
{
    public GameObject bullet;
    public Transform spawnPosition;

    public float bulletSpeed = 10; 

    void Start(){
        XRGrabInteractable theGunGrabable = GetComponent<XRGrabInteractable>();
        theGunGrabable.activated.AddListener(shootyshoot);
    }

    void Update(){
        
    }

    public void shootyshoot(ActivateEventArgs args)
    {
        GameObject newBullet = Instantiate(bullet);
        newBullet.Transform.position = spawnPosition.position;
        newBullet.Getcomponent<Rigidbody>().velocity = spawnPosition.forward * bulletSpeed;
    
        Destroy(newBullet, 10);
    }
}
