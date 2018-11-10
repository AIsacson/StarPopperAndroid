using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {

	public Rigidbody rb;
	public float speed;
	public GameObject child;

	private float moveHorizontal;
	private float moveVertical;
	private Vector3 movement;
	private Controller controller;
	private GameController gameController;
	private int score;
	private AudioSource plopSound;

	// Use this for initialization
	void Awake() {
		rb = GetComponent<Rigidbody> ();
		score = 0;
		gameController = FindObjectOfType<GameController> ();
	}

	void Start() {
		plopSound = GetComponent<AudioSource> ();
	}

	void LateUpdate() {
		child.transform.rotation = Quaternion.Euler(0.0f, 0.0f, this.transform.rotation.z * -1.0f);
	}
	
	// Update is called once per frame
	void Update () {
		moveVertical = Input.GetAxis ("Vertical");
		moveHorizontal = Input.GetAxis ("Horizontal");

		movement = new Vector3 (moveHorizontal, 0.0f, moveVertical);

		rb.AddForce (movement*speed);
	}

	void OnTriggerEnter(Collider other) {
		if (other.tag == "Cube") {
			plopSound.Play ();
			other.gameObject.SetActive (false);
			gameController.AddScore (score);
		}
	}
}
