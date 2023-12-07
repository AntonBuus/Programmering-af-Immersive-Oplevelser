using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnCups : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }
    public GameObject prefabToSpawn;
    public GameObject spawnPositionReference;
    public bool CupsHaveSpawned = false;
    // Update is called once per frame



    public void sspawnCups()
    {
        if (spawnPositionReference != null && CupsHaveSpawned == false)
            {
            Vector3 spawnPosition = spawnPositionReference.transform.position;
            Quaternion spawnRotation = spawnPositionReference.transform.rotation;

            Instantiate(prefabToSpawn, spawnPosition, spawnRotation);
            CupsHaveSpawned = true;
        }
            else
        {
            Debug.LogWarning("Spawn position reference is not set. Please assign a GameObject to spawnPositionReference.");
        }
    }
    void Update()
    {
        // Check if the 'D' key is pressed
        if (Input.GetKeyDown(KeyCode.D))
        {
            // Ensure there is a reference to the spawn position GameObject
            if (spawnPositionReference != null)
            {
                // Get the spawn position from the reference GameObject
                Vector3 spawnPosition = spawnPositionReference.transform.position;

                // Spawn the prefab at the determined position
                Instantiate(prefabToSpawn, spawnPosition, Quaternion.identity);
            }
            else
            {
                Debug.LogWarning("Spawn position reference is not set. Please assign a GameObject to spawnPositionReference.");
            }
        }
    }
}
