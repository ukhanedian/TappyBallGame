using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeSpawner : MonoBehaviour {

    public float MaxYpos; // Maximum Y position in which pipe will be instantiated
    public float SpawnTime; // Interval of Spawning the pipes
    public GameObject pipe; // Reference to the pipe

	// Use this for initialization
	void Start () {
		
        StartSpawnPipes();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void StopSpawningPipes () { // Stops calling SpawnPipe() function

        CancelInvoke ("SpawnPipe");
    }

    public void StartSpawnPipes () { // Repeatedly calls SpawnPipe() function

        InvokeRepeating ("SpawnPipe", 0.2f, SpawnTime);
    }

    void SpawnPipe () { // Spawns the pipe

        // Spawn pipe in the random y position
        Instantiate (pipe, new Vector3 (transform.position.x, Random.Range (-MaxYpos, MaxYpos), 0), Quaternion.identity);
    }
}
