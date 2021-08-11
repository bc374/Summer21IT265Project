using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreKeeper : MonoBehaviour
{
    public static ScoreKeeper instance;
    public int score, highScore;
    public Text scoreText, highScoreText;

    private void Awake()
    {
        instance = this;

        if (PlayerPrefs.HasKey("HighScore"))
        {
            highScore = PlayerPrefs.GetInt("HighScore");
            highScoreText.text = highScore.ToString();
        }
    }

    public void AddPoints()
    {
        score++;
        UpdateHighScore();

        scoreText.text = score.ToString();
    }

    public void UpdateHighScore()
    {
        if (score > highScore)
        {
            highScore = score;

            highScoreText.text = highScore.ToString();

            PlayerPrefs.SetInt("HighScore", highScore);
        }
    }

    public void ResetScore()
    {
        score = 0;
        scoreText.text = score.ToString();
    }
}
