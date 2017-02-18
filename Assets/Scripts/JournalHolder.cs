using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JournalHolder : MonoBehaviour {
    public string journal;
    private JournalScriptManager jman;
    public string[] dialogueLines;
	// Use this for initialization
	void Start () {
        jman = FindObjectOfType<JournalScriptManager>();
	}
	
	// Update is called once per frame
	void Update () {
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
    void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log("Here");
        if(other.gameObject.name == "Player")
        {
            if (Input.GetKeyDown(KeyCode.Space)) {
                if (!jman.journalActive)
                {
                    jman.dialogLines = dialogueLines;
                    jman.currentLine = 0;
                    jman.ShowDialogue();
                }
            }
        }
    }
}
