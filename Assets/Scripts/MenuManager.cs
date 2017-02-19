using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class MenuManager : MonoBehaviour {

	public void StartGame() {

		GameStats.QuestionsCorrect = 0;
		GameStats.QuestionsAsked = 0;
		GameStats.Munnie = 0;
		GameStats.Init = false;
		GameStats.CanMove = true;
		GameStats.GameMode = 0;
		GameStats.JournalFlag = 0;
		GameStats.DeathFlag = 0;
	    GameStats.TrainersBeaten = 0;
		GameStats.Beaten = new Dictionary<string, bool>();
		GameStats.BeatConnie = false;
		SceneManager.LoadScene("centralParkMapOneVersion2");
	}

	public void GoToMenu() {
		SceneManager.LoadScene("Main Menu");
	}
}
