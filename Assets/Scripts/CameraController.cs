using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour {
	public GameObject Player;
	private Vector3 Offset;
	// Use this for initialization
	void Start () {
		//calc Offset
		Offset = transform.position - Player.transform.position;
	}

	// Update is called once per frame
	void LateUpdate () {
		// Set the position of the camera's transform to be the same as the player's, but offset by the calculated offset distance.
        transform.position = Player.transform.position + Offset;
	}
}
