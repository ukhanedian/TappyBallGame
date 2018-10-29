using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallController : MonoBehaviour {

    public static BallController instance;

    Rigidbody2D rb; // Reference to the Rigidbody attached to the ball
    public float upForce; // Amount of force to upwards
    bool started; // tells that the game is started or not
    public bool gameOver; // tells that the game is over or not

    void Awake () {

        if (instance == null) {

            instance = this;
        }
    }

    // Use this for initialization
    void Start () {

        rb = GetComponent<Rigidbody2D> ();
        started = false; // Initially the game is not started
        gameOver = false; // Initially the game is not over
	}
	
	// Update is called once per frame
	void Update () {
		
        if ( ! started ) { // if the game is not started

            if (Input.GetMouseButtonDown (0)) { // if the mouse button is clicked or touch is happening

                started = true; // Make the game start
                rb.isKinematic = false; // Uncheck the isKinematic property
            }
        }
        else { // if our game has started

            if (Input.GetMouseButtonDown(0)) { // if the mouse button is clicked

                // Make the velocity of the ball zero
                rb.velocity = Vector2.zero;

                // Add an upward force to the ball
                rb.AddForce (new Vector2 (0, upForce));
            }
        }
	}

    void OnTriggerEnter2D (Collider2D col) {

        if (col.gameObject.tag == "Pipe") { // if the colliding object is Pipe

            // Make the game over
            gameOver = true;
        }

        if (col.gameObject.tag == "ScoreChecker" && !gameOver) { // if the colliding object is that box collider and the game is not over

            // increment the score
            ScoreManager.instance.IncrementScore ();
        }
    }
}
