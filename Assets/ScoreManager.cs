using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreManager : MonoBehaviour {

    public static ScoreManager instance; // Singleton
    public int score;

    void Awake () {

        if (instance == null) {

            instance = this;
        }
    }

	// Use this for initialization
	void Start () { // Start from the beginning

        score = 0; // Initializing the score
        PlayerPrefs.SetInt ("Score", 0); // Initializing the score in the PlayerPrefs also
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void IncrementScore () { // Increments the score

        score++;
    }

    public void StopScore () { // Saves our score

        PlayerPrefs.SetInt ("Score", score); // Save your score in the PlayerPrefs

        // Check and Save highScore in the PlayerPrefs
        if (PlayerPrefs.HasKey ("HighScore")) { // if we already have highscore

            // Check if your current score is greater than your highscore
            if (score > PlayerPrefs.GetInt ("HighScore")) {

                // Set your highscore by your score
                PlayerPrefs.SetInt ("HighScore", score);
            }
        }
        else {

            // Set your highscore by your score
            PlayerPrefs.SetInt ("HighScore", score);
        }
    }
}
