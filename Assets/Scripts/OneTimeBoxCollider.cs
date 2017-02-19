using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OneTimeBoxCollider : MonoBehaviour {

	void Update() {
		if (GameStats.GameMode == 4) {
			if(ID == 4) {
				StartCoroutine(Delayed());
		   }
		}
	}

	IEnumerator Delayed() {
		yield return new WaitForSeconds(0.5f);
		GameStats.Shown = false;
		GameStats.JournalFlag = 5;
		Destroy(this.gameObject);
	}
	public int ID;
	void OnTriggerEnter2D(Collider2D other) {
		if(other.gameObject.tag == "Player"){
			if(GameStats.GameMode == 0) {
				if(ID == 0){
					GameStats.JournalFlag += 1;
					GameStats.Shown = false;
					Destroy(this.gameObject);
				}
			 	else if (ID == 1) {
					GameStats.JournalFlag +=1;
					GameStats.Shown = false;
					Destroy(this.gameObject);
				}
			} else if(GameStats.GameMode == 1) {
				if(ID == 2) {
					GameStats.GameMode += 1;
					GameStats.JournalFlag +=1;
					GameStats.Shown = false;
					Destroy(this.gameObject);
				}
			} else if(GameStats.GameMode == 2) {
				if(ID == 3) {
				   GameStats.JournalFlag +=1;
				   GameStats.Shown = false;
				   Destroy(this.gameObject);
			   }
		   }
		}
	}
}
