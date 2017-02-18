using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class BattleManager : MonoBehaviour {

	public Text QuestionText;
	public Text ChoiceA;
	public Text ChoiceB;
	public Text ChoiceC;
	public Text ChoiceD;
	public Text Instruction;
	public int QuestionCount;
	public int TotalCount;
	public int NumRight;
	public int NumWrong;
	public int Redos;
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
		GameStats.LastScene = "Central Park 1 + AndrenaGalaxy Test Scene";
		StartBattle(Enemy);
	}

	// Update is called once per frame
	void Update () {
		if(Next == 0 && Input.GetKeyDown(KeyCode.Space)) {
			Next++;
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
		else if(Next == 4 && Input.GetKeyDown(KeyCode.Space)) {
			Dots();
		}

		else if(Next == 5 && Input.GetKeyDown(KeyCode.Space)) {
			if(QuestionCount < TotalCount && Redos > 0) {
				NextQuestion();
			} else {
				// end battle
				if(Redos <= 0) {
					// lose
					Lose();
				} else {
					// win
					Win();
				}
			}
		} else if(Next == 6 && Input.GetKeyDown(KeyCode.Space)) {
			AskQuestion();
		} else if(Next == 7 && Input.GetKeyDown(KeyCode.Space)) {
			SceneManager.LoadScene(GameStats.LastScene);
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
		Next = 0;
	}

	public void AskQuestion() {
		Instruction.gameObject.SetActive(false);
		ChoiceA.gameObject.SetActive(true);
		ChoiceB.gameObject.SetActive(true);
		ChoiceC.gameObject.SetActive(true);
		ChoiceD.gameObject.SetActive(true);
		// increment question counter
		QuestionCount += 1;
		Question current = new Question();
		// ask a question
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
		NumRight++;

		QuestionText.text = "Correct!";
		ChoiceA.gameObject.SetActive(false);
		ChoiceB.gameObject.SetActive(false);
		ChoiceC.gameObject.SetActive(false);
		ChoiceD.gameObject.SetActive(false);
		Instruction.gameObject.SetActive(true);
	}

	public void DisplayWrong() {
		NumWrong++;
		Redos--;

		QuestionText.text = "Incorrect! The answer is " + CurrentQuestion.Answer
			+ ". You have " + Redos + " lives remaining!";
		ChoiceA.gameObject.SetActive(false);
		ChoiceB.gameObject.SetActive(false);
		ChoiceC.gameObject.SetActive(false);
		ChoiceD.gameObject.SetActive(false);
		Instruction.gameObject.SetActive(true);
	}
	public void Dots() {
		QuestionText.text = "...";
		Instruction.gameObject.SetActive(true);
		Next = 5;
	}
	public void NextQuestion() {
		QuestionText.text = "Are you ready for the next question?";
		Instruction.gameObject.SetActive(true);
		Next = 6;
	}

	public void Lose() {
		QuestionText.text = Enemy.Name + " dropped some serious knowledge on you. You run away safely...";
		Instruction.gameObject.SetActive(true);
		Next = 7;
	}

	public void Win() {
		QuestionText.text = "You dropped some serious knowledge on " + Enemy.Name + ". They gave you $0.40 as a reward.";
		Enemy.Beaten = true;
		Next = 7;
	}

}
