using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPC : MonoBehaviour
{
	public string Name {get; set;}
	public SubjectType Subject;
	public DialogueManager diamang;
	private BattleManager batman;
	public string BattleEnterDialogue;
	public bool Beaten {get;set;}
	private AudioManager AMan;

	public NPC(string name, SubjectType subject)
	{
		Name = name;
		Subject = subject;
		Beaten = false;
	}

	void OnCollisionEnter2D(Collision2D other) {
		AMan = FindObjectOfType<AudioManager>();
		Debug.Log ("here");
		GameStats.Enemy = this;
		diamang.BattleFlag = true;
		diamang.ShowBox(this.name, this.BattleEnterDialogue );

	}
}
