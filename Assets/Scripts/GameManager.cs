using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour {
	public GameObject Player;

	public static Vector3 LastPlayerPosition;
	// Use this for initialization
	void Start () {
		Player.transform.position = LastPlayerPosition;
	}

	// Update is called once per frame
	void Update () {

	}
}
