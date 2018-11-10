using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuController : MonoBehaviour {

	public AudioSource plop;

	public void Restart() {
		SceneManager.LoadScene (SceneManager.GetActiveScene().buildIndex+1);
	}

	public void StartScene() {
		plop.Play ();
		Invoke ("OpenScene", 0.5f);
	}

	void OpenScene() {
		SceneManager.LoadScene (SceneManager.GetActiveScene ().buildIndex+1);
	}

	public void Quit() {
		SceneManager.LoadScene (SceneManager.GetActiveScene ().buildIndex);
	}
}
