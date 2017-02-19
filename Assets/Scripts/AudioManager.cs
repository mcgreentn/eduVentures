using System.Collections;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
	public AudioSource backgroundMusic;
	public AudioSource encounterSound;
	public AudioSource battleMusic;

	void Start() {
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
		backgroundMusic.Stop();
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
