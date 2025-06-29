using System;
using TMPro;
using UnityEngine;

public class Player_Score : MonoBehaviour
{
    public int score = 0;
    public TMP_Text scoreText;
    public int target = 20;
    public float totalTime = 180f; // Total time in seconds
    private float currentTime;
    private float time_done = 0f;
    public GameOverScript gameOverScript;
    public GameCompleted gameCompleted;
    public TextMeshProUGUI timerText; // Link to UI
    public bool gamerun = false;
    void Start()
    {
        currentTime = totalTime;
        UpdateScoreText();

    }

    void Update()
    {
        if (gamerun)
        {
            if (currentTime <= 10f)
            {
                timerText.color = Color.red;
            }
            if (currentTime > 0)
            {
                currentTime -= Time.deltaTime;
                UpdateTimerDisplay();
            }
            else
            {
                currentTime = 0;
                UpdateTimerDisplay();
                GameOver(); // Call game over logic
            }
            if (score >= target)
            {
                GameWon();
            }
        }
    }

    void UpdateTimerDisplay()
    {
        int minutes = Mathf.FloorToInt(currentTime / 60);
        int seconds = Mathf.FloorToInt(currentTime % 60);
        timerText.text = $"{minutes:00}:{seconds:00}";
    }

    void GameWon()
    {
        time_done = totalTime - currentTime;
        gameCompleted.setup(score,time_done);
    }
    void GameOver()
    {

        gameOverScript.setup(score);
        
    }
    public void IncrementScore(int amount)
    {
        score += amount;
        Debug.Log("score : " + score.ToString());
        UpdateScoreText();
    }

    void UpdateScoreText()
    {
        Debug.Log("score : " + score.ToString());
        scoreText.text = "Score: " + score.ToString() + " / " + target.ToString();
    }


}
