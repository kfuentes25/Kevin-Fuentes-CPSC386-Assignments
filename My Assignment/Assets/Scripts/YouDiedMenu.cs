using System.Collections;
using System.Collections.Generic;
using UnityEditor.PackageManager;
using UnityEngine;
using UnityEngine.SceneManagement;
using static PlayerMovementScript;

public class YouDiedMenu : MonoBehaviour
{
    [SerializeField] GameObject youDiedMenu;
    public static bool isPaused;

    private AudioSource _audioSource;
    public AudioClip hurtClip;
    void Start()
    {
        youDiedMenu.SetActive(false);
        _audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {

    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            LoadYouDied();
            PlaySFX(hurtClip);
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

    public void PlaySFX(AudioClip audioClip)
    {
        _audioSource.clip = audioClip;
        _audioSource.Play();
    }
}
