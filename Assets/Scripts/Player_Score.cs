using TMPro;
using UnityEngine;

public class Player_Score : MonoBehaviour
{
    public int score = 0;
    public TMP_Text scoreText;
    void Start()
    {
        UpdateScoreText();
    }

    public void IncrementScore(int amount)
    {
        score += amount;
// Debug.Log(score);
        UpdateScoreText();
    }

    void UpdateScoreText()
    {
        scoreText.text = "Score: " + score.ToString();
    }
}
