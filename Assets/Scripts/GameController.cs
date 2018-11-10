using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour {

	public Transform[] cubesSpawnPoints;
	public GameObject cube;
	public Text scoreBoard;
	public Canvas winboard;
	public Text finalTime;
	public Button restart;

	private int score;
	private Timer timer;
	private string time;

	// Use this for initialization
	void Awake () {
		SpawnFirstCubes ();
		scoreBoard.text = "Score: 0";
	}

	void Start() {
		timer = FindObjectOfType<Timer> ();
		winboard.enabled = false;
	}

	void SpawnFirstCubes() {
		for (int i = 0; i < cubesSpawnPoints.Length; i++) {
			cube = Instantiate (cube, cubesSpawnPoints [i].position, cubesSpawnPoints [i].rotation);
		}
	}

	public void AddScore(int newScore) {
		score += newScore+1;
		UpdateScore ();

	}

	void ShowWinText() {
		finalTime.text = time;
		winboard.enabled = true;
	}

	void UpdateScore() {
		if (score == 25) {
			time = timer.StopTimer (true);
			ShowWinText ();
		}
		scoreBoard.text = "Score: " + score;
	}
}
