using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;
public class GameOverScript : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public TMP_Text scoreText_final;
    public void setup(int score)
    {
         FindAnyObjectByType<PlayerMovement>().okaytoMove = false;
         FindAnyObjectByType<Player_Score>().gamerun = false;
        FindAnyObjectByType<FirstPersonController>().MoveCamera = false;
        gameObject.SetActive(true);
         scoreText_final.text = score.ToString() + " POINTS";
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
        Debug.Log("Exit Game");

        #if UNITY_EDITOR
                UnityEditor.EditorApplication.isPlaying = false; // Stops play mode in editor
        #else
            Application.Quit(); // Quits build
        #endif
    }
}
