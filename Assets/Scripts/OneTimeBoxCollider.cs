using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OneTimeBoxCollider : MonoBehaviour {

	public JournalHolder jh;
	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {

	}

	void OnCollisionEnter2D(Collision2D other) {
		if(GameStats.GameMode == 0) {
			GameStats.JournalFlag += 1;
			Destroy(this.gameObject);
		}
	}
}
