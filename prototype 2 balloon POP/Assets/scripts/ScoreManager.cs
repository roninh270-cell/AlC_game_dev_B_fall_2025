using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using TMPro; // include the UI textmech pro stuff

public class ScoreManager : MonoBehaviour
{
    public int score;// keep track of score
    public TextMeshProUGUI scoreText; // Refrence Text Ui object to update
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        UpdateScoreText();
    }

    public void IncreaseScoreText(int amount)
    {
        score += amount;//increase scoreby amount
        UpdateScoreText();// update score UI text
    }

    public void DecreaseScoreText(int amount)
    {
        score -= amount;//decrease scoreby amount
        UpdateScoreText();// update score UI text
    }

    public void UpdateScoreText()
    {
        scoreText.text = "score: " + score;
}
    // Update is called once per frame
    void Update()
    {
        
    }
}
