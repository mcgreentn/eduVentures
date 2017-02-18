﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DialogueManager : MonoBehaviour {

	public GameObject DBox;
	public Text DText;

	public bool DialogueActive;

	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {
		if(DialogueActive && Input.GetKey(KeyCode.Space)) {
			DBox.SetActive(false);
			DialogueActive = false;
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
	}
}