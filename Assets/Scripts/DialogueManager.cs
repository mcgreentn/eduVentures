using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class DialogueManager : MonoBehaviour {

	public GameObject DBox;
	public Text DText;

	public bool DialogueActive;

	public bool BattleFlag;
	public AudioManager AM;
	// Use this for initialization
	void Start () {
		AM.PlayBackground();
	}

	// Update is called once per frame
	void Update () {
		if(DialogueActive && Input.GetKey(KeyCode.Space)) {

			DBox.SetActive(false);
			DialogueActive = false;
			GameStats.CanMove = true;
			if (BattleFlag)
			{
				SceneManager.LoadScene ("Battle");

			}
			Debug.Log("Mode:" + GameStats.GameMode);
			if (GameStats.GameMode == 3) {
				GameStats.GameMode += 1;
			}
			Debug.Log("Mode:" + GameStats.GameMode);
		}

	}
	/**
	 * Shows the dialogue box with the character saying the text in this format
	 * [Character] : [text]
	 */
	public void ShowBox(string character, string text) {
		string newText = character + " : " + text;
		DText.text = newText;
		DialogueActive = true;
		DBox.SetActive(true);
		GameStats.CanMove = false;
	}

}
