﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Money_Text_Print : MonoBehaviour {
    public Text muney;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        muney.text = "You Earned: $" + GameStats.Munnie + " that's so much!";
	}
}
