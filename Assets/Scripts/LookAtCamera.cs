using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookAtCamera: MonoBehaviour {

	public GameObject target;
	Vector3 offset;

	// Use this for initialization
	void Start () {
		offset = transform.position - target.transform.position;
	}
	
	// You should always use LateUpdate() instead of the Update() method in all camera scripts. 
	// LateUpdate() happens after Update() has finished, so the Player script has a chance to
	// finish calculating the player's position before the camera calculates its position. 
	void LateUpdate () {

		Vector3 desiredPos = target.transform.position + offset;
		transform.position = desiredPos;
		// camera object is looking at the ball object.
		transform.LookAt (target.transform.position);
	}
}
