using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour {

    // Make a singleton instance
    public static GameManager instance;

    bool gameOver;

    void Awake () {

        // Never destroy when go to new scene
        DontDestroyOnLoad (this.gameObject);

        if (instance == null) {

            instance = this;
        } else {

            Destroy (this.gameObject);
        }
    }
	// Use this for initialization
	void Start () {

        gameOver = true;
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void GameStart () { // takes care of everything when the game starts

        // disable the StartUI
        UiManager.instance.GameStart ();

        // Start Spawning the Pipes
        GameObject.Find ("PipeSpawner").GetComponent<PipeSpawner> ().StartSpawningPipes ();
    }

    public void GameOver () { // takes care of everything when the game is over

        gameOver = false;

        // Stop Spawning the Pipes
        GameObject.Find ("PipeSpawner").GetComponent<PipeSpawner> ().StopSpawningPipes ();

        // Stop the score
        ScoreManager.instance.StopScore ();

        // activate gameOverPanel
        UiManager.instance.GameOver ();
    }
}
