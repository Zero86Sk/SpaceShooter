using UnityEngine;
using System.Collections;

public class SpawnObjects : MonoBehaviour {

    public GameObject objectToSpawn;
    public float spawnDelay = 1.0f;

	// Use this for initialization
	void Start ()
    {
        // If Invoke on start and end the values will stay douring respawning
        Invoke("Spawn", spawnDelay);
    }
	
	void Spawn ()
    {
        Instantiate(objectToSpawn, transform.position, transform.rotation);
        Invoke("Spawn", spawnDelay);
	}
}
