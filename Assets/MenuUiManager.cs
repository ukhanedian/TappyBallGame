using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; // Use anything related to scene management

public class MenuUiManager : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void Play () { // Takes our game to the play scene whenever the button is clicked

        SceneManager.LoadScene ("level1");
    }
}
