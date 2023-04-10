using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class AnswerSelection : MonoBehaviour
{
    public GameObject panelb;
    public Text answerText;

    public void OnAnswerSelected(string answer)
    {
        Time.timeScale = 0;
        Cursor.visible = true;
        Debug.Log("Selected answer: " + answer);
        answerText.text = "Selected answer: " + answer;
        panelb.SetActive(false);
    }
}


