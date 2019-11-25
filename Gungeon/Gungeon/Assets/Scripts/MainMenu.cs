using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; 

public class MainMenu : MonoBehaviour
{

    public void PlayGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void Options()
    {
        SceneManager.LoadScene("Options");
    }

    public void Instructions()
    {
        SceneManager.LoadScene("Instructions");
    }

    public void Back() // "back" buton on Instructions page; go back to intro scene, also used for "back" button on Options menu
    {
        SceneManager.LoadScene("Intro");
    }

    public void QuitGame()
    {
        // add a pop up text box later that asks if you're sure you want to quit
        Application.Quit();
    }
}
