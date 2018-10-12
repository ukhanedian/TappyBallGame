using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeController : MonoBehaviour {

    public float speed; // speed a pipe will move
    public float upDownSpeed; // another speed in the up and down direction
    Rigidbody2D rb; // Get access to the Rigidbody 2D inside the pipe

	// Use this for initialization
	void Start () {

        rb = GetComponent<Rigidbody2D> ();
        MovePipe ();
        InvokeRepeating ("SwitchUpDown", 0.1f, 1f);
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    // A function will switch direction between up and down
    void SwitchUpDown () {

        upDownSpeed = -upDownSpeed; // changes the direction
        rb.velocity = new Vector2 (-speed, upDownSpeed);
    }

    // A function that will move our pipe in the x direction
    void MovePipe () {

        // Add velocity to the pipe
        rb.velocity = new Vector2 (-speed, upDownSpeed);
    }
}
