using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BattleManager : MonoBehaviour {

	public Text QuestionText;
	public Text ChoiceA;
	public Text ChoiceB;
	public Text ChoiceC;
	public Text ChoiceD;
	public Text Instruction;

	public int Next;

	public NPC Enemy;
	public SubjectType subject;
	public Question CurrentQuestion;
	// Use this for initialization
	void Start () {
		Next = -1;

		// Debug
		NPC tester = new NPC("Charles", SubjectType.Math);


		Enemy = tester;
		StartBattle(Enemy);

	}

	// Update is called once per frame
	void Update () {
		if(Next == 0 && Input.GetKeyDown(KeyCode.Space)) {
			Next++;
			Instruction.gameObject.SetActive(false);
			ChoiceA.gameObject.SetActive(true);
			ChoiceB.gameObject.SetActive(true);
			ChoiceC.gameObject.SetActive(true);
			ChoiceD.gameObject.SetActive(true);
			AskQuestion();
		}
		if(Next == 2) {
			if(Input.GetKeyDown(KeyCode.Alpha1)) {
				Next = 3;
				AnswerQuestion(1);
			} else if(Input.GetKey(KeyCode.Alpha2)) {
				Next = 3;
				AnswerQuestion(2);
			} else if(Input.GetKey(KeyCode.Alpha3)) {
				Next = 3;
				AnswerQuestion(3);
			} else if(Input.GetKey(KeyCode.Alpha4)) {
				Next = 3;
				AnswerQuestion(4);
			}
		}
	}
	/**
	 * Start battle with the current enemy. Start the dialogue with an enemy and set Next = 0;
	 */
	public void StartBattle(NPC Enemy) {
		ChoiceA.gameObject.SetActive(false);
		ChoiceB.gameObject.SetActive(false);
		ChoiceC.gameObject.SetActive(false);
		ChoiceD.gameObject.SetActive(false);
		Instruction.gameObject.SetActive(true);
		this.Enemy = Enemy;
		this.subject = Enemy.Subject;
		Debug.Log(Enemy.Name);
		QuestionText.text = Enemy.Name + " wants to quiz test you!";
		// AskQuestion();
		Next = 0;
	}

	public void AskQuestion() {
		Question current = new Question();
		switch(subject) {
			case SubjectType.Math:
				current = QuestionParser.MathQs[UnityEngine.Random.Range(0, QuestionParser.MathQs.Count)];
				break;
			case SubjectType.History:
				current = QuestionParser.HistoryQs[UnityEngine.Random.Range(0, QuestionParser.HistoryQs.Count)];
				break;
			case SubjectType.Science:
				current = QuestionParser.ScienceQs[UnityEngine.Random.Range(0, QuestionParser.ScienceQs.Count)];
				break;
			case SubjectType.English:
				current = QuestionParser.EnglishQs[UnityEngine.Random.Range(0, QuestionParser.EnglishQs.Count)];
				break;
		}
		CurrentQuestion = current;
		QuestionText.text = current.Q;
		ChoiceA.text = current.ChoiceA;
		ChoiceB.text = current.ChoiceB;
		ChoiceC.text = current.ChoiceC;
		ChoiceD.text = current.ChoiceD;
		Debug.Log(CurrentQuestion.Answer);
		Next = 2;
	}

	public void AnswerQuestion(int choice) {
		int y = 0;
		Int32.TryParse(CurrentQuestion.Answer, out y);
		Next = 4;
		if(choice == y) {
			// got question correct
			DisplayRight();
		} else {
			// got question wrong
			DisplayWrong();
		}
	}

	public void DisplayRight() {
		QuestionText.text = "Correct!";
		ChoiceA.gameObject.SetActive(false);
		ChoiceB.gameObject.SetActive(false);
		ChoiceC.gameObject.SetActive(false);
		ChoiceD.gameObject.SetActive(false);
		Instruction.gameObject.SetActive(true);
	}

	public void DisplayWrong() {
		QuestionText.text = "Incorrect!";
		ChoiceA.gameObject.SetActive(false);
		ChoiceB.gameObject.SetActive(false);
		ChoiceC.gameObject.SetActive(false);
		ChoiceD.gameObject.SetActive(false);
		Instruction.gameObject.SetActive(true);
	}

}
