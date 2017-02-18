using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class NPC : MonoBehaviour
{
	public string Name;
	public SubjectType Subject;
	public DialogueManager diamang;
	private BattleManager batman;
	public string BattleEnterDialogue;
	public string PostBattleDialogue;
	public GameManager GM;
	public int ID;
	public bool Beaten {get;set;}
	public static int LastID;

	private NPC self;

	void Start() {
		ID = LastID;
		LastID++;
		if(!GameStats.Init) {
			GameStats.Beaten.Add(Name, false);
		}
	}
	public NPC(string name, SubjectType subject)
	{


	}

	void OnCollisionEnter2D(Collision2D other) {
		if(!GameStats.Beaten[Name]) {
			GameStats.EnemyName = Name;
			GameStats.EnemySubject = Subject;
			GameStats.EnemyID = ID;
			Debug.Log("ID = " + ID);
			Debug.Log("Name = " + Name);
			diamang.BattleFlag = true;
			diamang.ShowBox(this.name, this.BattleEnterDialogue);
			GameStats.LastScene = SceneManager.GetActiveScene().name;
			GM.SavePlayerPosition();
		} else {
			diamang.BattleFlag = false;
			diamang.ShowBox(this.name, this.PostBattleDialogue);
		}
	}
}
