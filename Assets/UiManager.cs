using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class UiManager : MonoBehaviour {

    // Make a singleton instance
    public static UiManager instance;

    // Create a reference to gameOverPanel
    public GameObject gameOverPanel;

    // Create a reference to startUI
    public GameObject startUI;

    // Create a reference to GameOver Text
    public GameObject gameOverText;

    // Make some public variables to assign Ui elements
    public Text scoreText;

    // Create a reference to highScore Text
    public Text highScoreText;

    void Awake () {

        if (instance == null) {

            instance = this;
        }
    }

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        // In every frame we need to update the scoreText
        scoreText.text = ScoreManager.instance.score.ToString ();
        Debug.Log (ScoreManager.instance.score);
    }

    // function for game in play
    public void GameStart () {

        startUI.SetActive (false);
    }

    // function for gameOver animation
    public void GameOver () {

        gameOverText.SetActive (true); // enables Game Over Text
        highScoreText.text = PlayerPrefs.GetInt ("Highscore").ToString(); // displays highscore
        gameOverPanel.SetActive (true); // enables Game Over Panel
    }

    // function for Replay button
    public void Replay () {

        SceneManager.LoadScene ("level1");
    }

    // function for Menu button
    public void Menu () { // returns us to the main menu

        SceneManager.LoadScene ("Menu");
    }
}
