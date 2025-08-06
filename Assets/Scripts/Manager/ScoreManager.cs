using UnityEngine;
using TMPro;

public class ScoreManager : MonoBehaviour
{
    public TextMeshProUGUI scoreText;
    public TextMeshProUGUI highScoreText;
    public static ScoreManager instance;
    public static int score;
    public int highScore;
    private EnemyManager enemyManager;
    void Start()
    {
        instance = this;
        score = 0;
        LoadGameScore();
        highScoreText.text = "High Score: " + highScore.ToString();
    }

    void Update()
    {
        scoreText.text = "Score: " + score;
    }

    private void LoadGameScore()
    {
        if (PlayerPrefs.HasKey("HighScore"))
        {
            highScore = PlayerPrefs.GetInt("HighScore");
            highScoreText.text = "High Score: " + highScore;
        }
        else
        {
            highScore = 0;
            PlayerPrefs.SetInt("HighScore", highScore);
        }
    }

    private void SaveGameScore()
    {
        PlayerPrefs.SetInt("HighScore", highScore);
    }

    public void CurrentScore()
    {
        scoreText.text = "Score: " + score;
        if (score > highScore)
        {
            highScore = score;
            highScoreText.text = "High Score: " + highScore;
            SaveGameScore();
        }
    }
}
