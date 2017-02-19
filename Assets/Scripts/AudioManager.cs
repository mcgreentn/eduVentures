using System.Collections;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
	public AudioSource backgroundMusic;
	public AudioSource encounterSound;
	public AudioSource battleMusic;

	public AudioSource duelSound;

	void Start() {
	}

	void Update() {

}
	public void PlayBackground() {
		battleMusic.Stop();
		backgroundMusic.Play();
	}
	public void PlayAlert() {
		encounterSound.Play();
		backgroundMusic.Stop();
	}
	public void PlayBattle() {
		duelSound.Play();
		backgroundMusic.Stop();
		StartCoroutine(PlayBattleMusic());
	}

	IEnumerator PlayBattleMusic() {
		yield return new WaitForSeconds(3.7f);
		battleMusic.Play();
	}
////	private static bool playerExists;
//
//	// Use this for initialization
//	void Start ()
//	{
//
//	}
//
}
