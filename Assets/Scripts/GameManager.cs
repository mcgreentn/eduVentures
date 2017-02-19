using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class GameManager : MonoBehaviour {
	public GameObject Player;
	public GameObject Camera;

	public static Vector3 LastPlayerPosition;
	public static Vector3 StartPlayerPosition;
	// Use this for initialization
	void Start () {
		SetStartPosition();
		if(GameStats.BattleWon == 1) {
			Player.transform.position = LastPlayerPosition;
			Vector3 camPos = new Vector3(LastPlayerPosition.x, LastPlayerPosition.y, -10f);
			Camera.transform.position = camPos;
			Debug.Log("Last Pos");
		} else if(GameStats.BattleWon == 2) {
			Player.transform.position = StartPlayerPosition;
			Debug.Log("Start Pos");
		}
	}

	// Update is called once per frame
	void Update () {

	}


	public void SavePlayerPosition() {
		LastPlayerPosition = Player.transform.position;
	}

	public void SetStartPosition() {
		if(SceneManager.GetActiveScene().name.Equals("centralParkMapOneVersion2")) {
			StartPlayerPosition = new Vector3(-4.26f, -4.08f, 0f);
		} else if(SceneManager.GetActiveScene().name.Equals("CentralParkBossLevel")) {
			StartPlayerPosition = new Vector3(-1.94f, -8.15f, 0f);
		}
	}
}
