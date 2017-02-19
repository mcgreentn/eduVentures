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
        UpdateJournalLines();
    }

	// Update is called once per frame
	void Update () {
        // check to see if GameStats updated
        if(littleFlag != GameStats.JournalFlag) {
            littleFlag = GameStats.JournalFlag;
            UpdateJournalLines();
            if(!GameStats.Shown) {
                Show();
                GameStats.Shown = true;
            }
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
        } else if(littleFlag == 1) {
            dialogueLines = new string[] {"It’s unsafe! Weird people live in central park! You need to read the safety sign for your own protection. Step up to the sign to read it."};
        } else if(littleFlag == 2) {
            dialogueLines = new string[] {"Looks like there is some graffiti written on the sign…"};
        } else if(littleFlag == 3) {
            dialogueLines = new string[] {"\"She won't come back to school? Well, as her best friend, it is my duty to make sure she comes back!\" you think to yourself.","See if the people in park have seen Connie. Walk up to strangers to talk to them. "};
        } else if(littleFlag == 4) {
            dialogueLines = new string[] {"Connie is there out on the pier. You found her!", "You should go talk to her and try to convince her to come back with you to school."};
        } else if(littleFlag == 5) {
            dialogueLines = new string[] {"Now relaxed and refreshed from an unusual day in Central Park, you and Connie walk back to school ready to the Regionals test."};
        }
    }

    public void Show() {
        if(GameStats.DeathFlag == 0) {
            GameStats.CanMove = false;
            jman.dialogLines = dialogueLines;
            jman.currentLine = 0;
            jman.jtext.text = dialogueLines[0];
            jman.ShowDialogue();
        } else {
            GameStats.DeathFlag = 0;
        }
    }
}
