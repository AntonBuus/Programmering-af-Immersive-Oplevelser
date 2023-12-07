using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnBall : MonoBehaviour
{

    public GameObject prefabToSpawn;
    public GameObject spawnPositionReference;

    public void sspawnBall()
    {
        if (spawnPositionReference != null)
        {
            Vector3 spawnPosition = spawnPositionReference.transform.position;

            Instantiate(prefabToSpawn, spawnPosition, Quaternion.identity);
            
        }
        else
        {
            Debug.LogWarning("Spawn position reference is not set. Please assign a GameObject to spawnPositionReference.");
        }
    }
    
}
