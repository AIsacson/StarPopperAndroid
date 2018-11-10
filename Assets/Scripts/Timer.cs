using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour {

	public Text timer;
	private int minutes;
	private float seconds;
	private bool stopped = false;

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		StartTimer ();
	}

	public string StopTimer(bool stop) {
		stopped = stop;
		return timer.text;
	}

	void StartTimer() {
		if (!stopped) {
			seconds += Time.deltaTime;
			timer.text = "Time: " + minutes.ToString ("00") + ":" + ((int)seconds).ToString ("00");

			if (seconds >= 60) {
				minutes++;
				seconds = 0;
			}
		}
	}
}
