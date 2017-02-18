using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NonEnemyNPC : MonoBehaviour {

	public string Name;
	public string Dialogue;
	public DialogueManager diamang;

	void OnCollisionEnter2D(Collision2D other) {
		Debug.Log ("here");
		if(this.Name.Equals("Construction Sign")) {
			// trigger journal
			GameStats.GameMode = 1;
		}
		diamang.ShowBox(this.name, this.Dialogue );

	}
}
