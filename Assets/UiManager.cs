using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UiManager : MonoBehaviour {

    // Make a singleton instance
    public static UiManager instance;

    // Make some public variables to assign Ui elements
    public Text scoreText;

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
}
