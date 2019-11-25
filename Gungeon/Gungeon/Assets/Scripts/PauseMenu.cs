using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    public GameObject pauseMenuUI;
    public static bool GamePaused = false; // default

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (GamePaused)
            {
                Resume();
            }
            else
            {
                Pause();
            }
        };
    }

    public void Resume()
    {
        pauseMenuUI.SetActive(false); // disables pause menu
        Time.timeScale = 1f; // resumes to normal time
        GamePaused = false;
    }

    public void Pause()
    {
        pauseMenuUI.SetActive(true); // enables pause menu
        Time.timeScale = 0f; // freeze time
        GamePaused = true;
    }

    public void LoadMenu()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("Intro");
    }

    public void LoadOptions()
    {
        SceneManager.LoadScene("Options");
    }

    // add in pop-up window that asks if you really want to quit
    public void QuitGame()
    {
        Application.Quit();
    }
}
