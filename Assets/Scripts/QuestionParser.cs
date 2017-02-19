using System;
﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuestionParser : MonoBehaviour {
	public TextAsset[] QuestionsDict;

	public static List<Question> MathQs;
	// public static List<Question> EnglishQs;
	public static List<Question> ScienceQs;
	public static List<Question> HistoryQs;
	//Singleton
	private static QuestionParser instance = null;

	private static bool made;
	public static QuestionParser Instance
	{
		get
		{
			return instance;
		}
	}

	void Awake()
	{
		if (instance != null && instance != this)
		{
			Destroy(this.gameObject);
			return;
		}
		else
		{
			instance = this;
		}
		DontDestroyOnLoad(this.gameObject);
	}

	// Use this for initialization
	void Start () {
		if(!made) {
			MathQs = new List<Question>();
			// EnglishQs = new List<Question>();
			ScienceQs = new List<Question>();
			HistoryQs = new List<Question>();
			// loop through every text asset, split apart by line into split
			string[] split = QuestionsDict[0].text.Replace("\r\n", "\n").Replace("\r","\n").Split("\n"[0]);
			for(int i = 0; i < split.Length-1; i+=6) {
				Question q = new Question(split[i], split[i+1], split[i+2], split[i+3], split[i+4], split[i+5]);
				Debug.Log(split[i]);
				MathQs.Add(q);
			}
			// split = QuestionsDict[1].text.Replace("\r\n", "\n").Replace("\r","\n").Split("\n"[0]);
			// for(int i = 0; i < split.Length-1; i+=6) {
			// 	Question q = new Question(split[i], split[i+1], split[i+2], split[i+3], split[i+4], split[i+5]);
			// 	EnglishQs.Add(q);
			// }
			split = QuestionsDict[1].text.Replace("\r\n", "\n").Replace("\r","\n").Split("\n"[0]);
			for(int i = 0; i < split.Length-1; i+=6) {
				Question q = new Question(split[i], split[i+1], split[i+2], split[i+3], split[i+4], split[i+5]);
				HistoryQs.Add(q);
			}
			split = QuestionsDict[2].text.Replace("\r\n", "\n").Replace("\r","\n").Split("\n"[0]);
			for(int i = 0; i < split.Length-1; i+=6) {
				Question q = new Question(split[i], split[i+1], split[i+2], split[i+3], split[i+4], split[i+5]);
				ScienceQs.Add(q);
			}
			made = true;
		}
	}
}
