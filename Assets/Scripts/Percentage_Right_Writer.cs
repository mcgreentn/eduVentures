using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Percentage_Right_Writer : MonoBehaviour
{
    public Text percent;
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        percent.text = "You got a: " + string.Format("{0:0.00}",((GameStats.QuestionsCorrect*1.0f)/(GameStats.QuestionsAsked *1.0f) *100f)) + "%" ;
    }
}