using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour {
	public GameObject Player;

	public static Vector3 LastPlayerPosition;
	public static Vector3 StartPlayerPosition;
	// Use this for initialization
	void Start () {
		if(GameStats.BattleWon == 1) {
			Player.transform.position = LastPlayerPosition;
		} else if(GameStats.BattleWon == 2) {
			Player.transform.position = StartPlayerPosition;
		}
	}

	// Update is called once per frame
	void Update () {

	}
}
