using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class JournalScriptManager : MonoBehaviour {
    public GameObject jBox;
    public Text jtext;
    public bool journalActive;
    public string[] dialogLines;
    public int currentLine;

	// Use this for initialization
	void Start () {
	}

    // Update is called once per frame
    void Update() {

        if (journalActive && Input.GetKeyDown(KeyCode.Space)) {
            currentLine += 1;
            //jBox.SetActive(false);
            //journalActive = false;
            if(currentLine>= dialogLines.Length)
            {
                jBox.SetActive(false);
                journalActive = false;
                currentLine = 0;
                GameStats.CanMove = true;
            }
            jtext.text = dialogLines[currentLine];
        }
     //  if (!journalActive)
       // {
         //   jBox.SetActive(false);
        //}
    }
    public void ShowBox(string dialogue)
    {
        journalActive = true;
        jBox.SetActive(true);
        jtext.text = dialogue;
    }
    public void ShowDialogue()
    {
        journalActive = true;
        jBox.SetActive(true);
    }

}
