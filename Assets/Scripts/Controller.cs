using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller : MonoBehaviour {
	private GameController gameController;

	// Use this for initialization
	void Awake () {
		gameController = FindObjectOfType<GameController> ();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void AddScore(int score) {
		gameController.AddScore (score);
	}
}
