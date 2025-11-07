using System.Collections;
using System.Collections.Generic;
using UnityEditor.PackageManager;
using UnityEngine;
using UnityEngine.SceneManagement;

public class YouDiedMenu : MonoBehaviour
{
    [SerializeField] GameObject youDiedMenu;
    public static bool isPaused;
    void Start()
    {
        youDiedMenu.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {

    }
    // void OnTriggerEnter2D(Collider2D collision)
    // {
    //     if (collision.tag == "Player")
    //     {
    //         SceneManager.LoadScene("You Died");
    //     }
    // }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            LoadYouDied();
        }
    }
    public void LoadYouDied()
    {
        youDiedMenu.SetActive(true);
        Time.timeScale = 0;
        isPaused = true;
    }

    public void RestartLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        Time.timeScale = 1;
        isPaused = false;
    }
}
