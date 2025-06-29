using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameStart : MonoBehaviour
{
    public GameObject score_canvas;
    public GameObject start_canvas;
    public GameObject camera_o;
    public GameObject player;
    public GameObject spawner;
    public static bool gamestarted = false;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //Debug.Log("gamestarted value : " + gamestarted);

        if (gamestarted)
        {
            startButton();
        }
        else
        {
            camera_o.SetActive(true);
            player.SetActive(false);
            spawner.SetActive(false);
            score_canvas.SetActive(false);
            start_canvas.SetActive(true);
            // FindAnyObjectByType<PlayerMovement>().okaytoMove = false;
            //  FindAnyObjectByType<Player_Score>().gamerun = false;
            Cursor.lockState = CursorLockMode.None; // Unlock
            Cursor.visible = true;
            gamestarted = true;
        }

    }

    public void startButton()
    {
        score_canvas.SetActive(true);
        camera_o.SetActive(true);
        player.SetActive(true);
        spawner.SetActive(true);
        start_canvas.SetActive(false);
       // SceneManager.LoadScene("FireQuest_scene");
        FindAnyObjectByType<PlayerMovement>().okaytoMove = true;
        FindAnyObjectByType<Player_Score>().gamerun = true;
        FindAnyObjectByType<FirstPersonController>().MoveCamera = true;


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
