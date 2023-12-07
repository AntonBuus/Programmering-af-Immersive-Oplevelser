using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CupBreak : MonoBehaviour
{

    SphereCollider collider;
    MeshRenderer mr;
    //public gameObject ball;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.name == "Ball")
        {
            //mr.enabled = false;
            //collider.enabled = false;
            Destroy(gameObject);
            FindObjectOfType<AudioManager>().Play("Click");
            Debug.Log("Balls");
        }
    }
}
