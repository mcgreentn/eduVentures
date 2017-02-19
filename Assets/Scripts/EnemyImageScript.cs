using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class EnemyImageScript : MonoBehaviour {
	public Sprite[] sprites;
	// Use this for initialization
	void Start () {
		if(GameStats.EnemyName.Equals("Youngster Joey")) {
			this.GetComponent<Image>().sprite = sprites[0];
		} else if(GameStats.EnemyName.Equals("Lunching Office Worker")) {
			this.GetComponent<Image>().sprite = sprites[1];
		} else if(GameStats.EnemyName.Equals("Artist Painting the Lake")) {
			this.GetComponent<Image>().sprite = sprites[2];
		} else if(GameStats.EnemyName.Equals("Ice Skater")) {
			this.GetComponent<Image>().sprite = sprites[3];
		} else if(GameStats.EnemyName.Equals("Woman napping in the flowers")) {
			this.GetComponent<Image>().sprite = sprites[4];
		} else if(GameStats.EnemyName.Equals("Urban Weight Lifter")) {
			this.GetComponent<Image>().sprite = sprites[5];
		} else if(GameStats.EnemyName.Equals("Boss")) {
			this.GetComponent<Image>().sprite = sprites[6];
		}

	}

	// Update is called once per frame
	void Update () {

	}
}
