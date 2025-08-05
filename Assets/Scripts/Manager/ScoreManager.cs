using UnityEngine;
using Unity.UI;
using TMPro;
using System;

public class ScoreManager : MonoBehaviour
{
    public TextMeshProUGUI scoreText;
    public TextMeshProUGUI highScoreText;
    public static ScoreManager instance;
    public int score;
    public int highScore;

    void Start()
    {
        instance = this;
        score = 0;
    }

    void Update()
    {
        scoreText.text = "Score: " + score;
    }

    public void AddScore(int scoreValue)
    {
        score += scoreValue;
    }
}
