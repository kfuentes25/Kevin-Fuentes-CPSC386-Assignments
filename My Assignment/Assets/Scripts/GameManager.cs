using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public void ToSettings()
    {
        SceneManager.LoadSceneAsync("Settings Menu");
    }
    public void ToPauseMenu()
    {
        SceneManager.LoadScene("Pause Menu");
    }
    public void ToMainMenu()
    {
        SceneManager.LoadScene("Main Menu");
    }
    public void ToLevelsMenu()
    {
        SceneManager.LoadScene("Levels Menu");
    }
    public void ToLevelOne()
    {
        SceneManager.LoadScene("Level 1");
    }
    public void ToLevelTwo()
    {
        SceneManager.LoadScene("Level 2");
    }
    public void ToLevelThree()
    {
        SceneManager.LoadScene("Level 3");
    }
    public void ToLevelFour()
    {
        SceneManager.LoadScene("Level 4");
    }
    public void QuitGame()
    {
        Application.Quit();
    }
    // public bool BackToLevelFromPause()
    // {
    //     public static bool GameIsPaused = false;

    //     void Update()
    //     {
    //         if (Input.GetKeyDown(KeyCode.Escape))
    //         {
    //             if (GameIsPaused)
    //                 Resume();
    //             else
    //                 Pause();
    //         }
    //     }
    //     public void Resume()
    //     {
    //         pauseMenuUI.SetActive(false);
    //         Time.timeScale = 1f;  // resumes time
    //         GameIsPaused = false;
    //     }

    // }
}
