using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Text))]

public class ScoreSystem : MonoBehaviour
{
    private int score;
    private int oldscore;
    public void addScore()
    {
        score += 100;
    }
    [SerializeField]
    private Text text;

    private void Awake()
    {
        score = 0;
        string score_text = "Score: " + score.ToString();
        text.text = score_text;
    }

    private void Update ()
    {
        if(score != oldscore)
        {
            string score_text = "Score: " + score.ToString();
            text.text = score_text;
            oldscore = score;
        }
	}

    private void FixedUpdate()
    {
        if (Input.GetButtonDown("Jump")) score += 100;
    }
}