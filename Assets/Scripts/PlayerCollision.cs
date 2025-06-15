using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerCollision : MonoBehaviour
{
    int scoreValue = 1;
    public Player_Score Player_Score;

    private void Start()
    {
        Player_Score = FindFirstObjectByType<Player_Score>();
    }
    void OnParticleCollision(GameObject other)
    {
        Debug.Log("Hit: " + other.name + " With : " + gameObject.name);
        Destroy(gameObject);

        if (Player_Score != null)
        {
            Player_Score.IncrementScore(scoreValue);
        }
    }
}