using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotation : MonoBehaviour {

	private float speed = 2.0f;

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		transform.Rotate (new Vector3 (10, 40, 50) * Time.deltaTime * speed);
	}
}
