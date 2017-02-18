using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JournalHolder : MonoBehaviour {
    public string journal;
    private JournalScriptManager jman;
    public string[] dialogueLines;

    public int littleFlag = -1;
	// Use this for initialization
	void Start () {
        jman = FindObjectOfType<JournalScriptManager>();
        littleFlag = 0;
        UpdateJournalLines();
    }

	// Update is called once per frame
	void Update () {
        // check to see if GameStats updated
        if(littleFlag != GameStats.JournalFlag) {
            littleFlag = GameStats.JournalFlag;
            UpdateJournalLines();
            Show();
        }
        if (Input.GetKeyDown(KeyCode.J))
        {
            if (!jman.journalActive)
            {
                jman.dialogLines = dialogueLines;
                jman.currentLine = 0;
                jman.jtext.text = dialogueLines[0];
                jman.ShowDialogue();
            }
        }
    }

    public void UpdateJournalLines(){
        if(littleFlag == 0) {
            dialogueLines = new string[] {"Studying for tests is boring but it doesn’t have to be. It can be like a game.",
            "Today is your 6th grade class New York State regents testing day! You are nervous about taking your tests...it can be stressful...",
            "Through your window, you see your best friend Connie walking away from school towards Central Park. What is she doing??!",
            "You decide to follow her..."};
            Show();
        }
        if(littleFlag == 1) {
            dialogueLines = new string[] {"It’s unsafe! Weird people live in central park! You need to read the safety sign for your own protection. Step up to the sign to read it."};
        }
    }

    public void Show() {
        GameStats.CanMove = false;
        jman.dialogLines = dialogueLines;
        jman.currentLine = 0;
        jman.jtext.text = dialogueLines[0];
        jman.ShowDialogue();
    }
}
