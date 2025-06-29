using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameCompleted : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public TMP_Text scoreText_final;
    string time_done;
    public void setup(int score, float time)
    {
        
        FindAnyObjectByType<PlayerMovement>().okaytoMove = false;
        FindAnyObjectByType<Player_Score>().gamerun = false;
        FindAnyObjectByType<FirstPersonController>().MoveCamera = false;
        gameObject.SetActive(true);
        int minutes = Mathf.FloorToInt(time / 60);
        int seconds = Mathf.FloorToInt(time % 60);
        time_done = $"{minutes:00}:{seconds:00}";

        scoreText_final.text = "COLLECTED " + score.ToString() + " fires in " + time_done + " Mins";
        
        Cursor.lockState = CursorLockMode.None; // Unlock
        Cursor.visible = true;

    }

    public void restartButton()
    {

        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);



        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }

    public void ExitGame()
    {
        #if UNITY_EDITOR
             UnityEditor.EditorApplication.isPlaying = false; // Stops play mode in editor
        #else
              Application.Quit(); // Quits build
        #endif
    }
}
