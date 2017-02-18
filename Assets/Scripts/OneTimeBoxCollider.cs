using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OneTimeBoxCollider : MonoBehaviour {


	public int ID;
	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {

	}

	void OnTriggerEnter2D(Collider2D other) {
		if(other.gameObject.tag == "Player"){
		if(GameStats.GameMode == 0) {
			if(ID == 0){
				GameStats.JournalFlag += 1;
				Destroy(this.gameObject);
			}
		 	else if (ID == 1) {
				GameStats.JournalFlag +=1;
				Destroy(this.gameObject);
			}
		} else if(GameStats.GameMode == 1) {
				if(ID == 2) {
					GameStats.JournalFlag +=1;
					Destroy(this.gameObject);
				}
			}
		}
	}
}
